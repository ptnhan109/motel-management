using Motel.Application.Extentions;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Motel.Application.Models;
using Motel.Application.Mapper;
using System.Drawing;

namespace Motel.Application.Helpers
{
    public static class ExcelHelper
    {
        public static async Task<string> ExportExcel(List<dynamic> items, Type type, string? title = "")
        {
            /// generate file name
            string fileName = Guid.NewGuid().ToString().Replace("-", string.Empty);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Assets","Templates", "ExportTemplate.xlsx");
            string destPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Exports", $"{fileName}.xlsx");

            string savedFolder = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Exports");
            if (!Directory.Exists(savedFolder))
            {
                Directory.CreateDirectory(savedFolder);
            }

            var file = new FileInfo(path);


            using (ExcelPackage package = new ExcelPackage(file))
            {
                int startRecord = 9;
                var worksheet = package.Workbook.Worksheets[0];

                GenerateHeader(type, ref worksheet);

                for (int index = 0; index < items.Count(); index++)
                {
                    GenerateRow(items[index], startRecord, index, ref worksheet, true);
                    startRecord++;
                }

                await package.SaveAsAsync(destPath);
                var result = File.ReadAllBytes(destPath);
                Task.Run(() =>
                {
                    File.Delete(destPath);
                });

                return Convert.ToBase64String(result);
            }

        }

        private static void GenerateTile(ref ExcelWorksheet sheet, DateTime? fromDate, DateTime? toDate, string? title = "")
        {
            if (!string.IsNullOrEmpty(title))
            {
                sheet.Cells["A5"].Value = title.ToUpper();
            }
            else
            {
                sheet.Cells["A5"].Value = string.Empty;
            }

            if (fromDate.HasValue && toDate.HasValue)
            {
                sheet.Cells["A6"].Value = $"Từ ngày {fromDate.Value.ToString("dd-MM-yyyy")} đến ngày {toDate.Value.ToString("dd-MM-yyyy")}";
            }
            else
            {
                sheet.Cells["A6"].Value = string.Empty;
            }

            return;
        }

        private static void GenerateHeader(Type type, ref ExcelWorksheet sheet)
        {
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var excelAttribute = property?.GetCustomAttributes(typeof(ExcelAttribute), false)?.FirstOrDefault();
                if (excelAttribute != null)
                {
                    var attribute = excelAttribute as ExcelAttribute;
                    string header = attribute.Header;
                    sheet.Cells[8, attribute.Index].Value = header;
                    sheet.Cells[8, attribute.Index].Style.Fill.SetBackground(Color.DeepSkyBlue);
                    sheet.Cells[8, attribute.Index].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[8, attribute.Index].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[8, attribute.Index].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[8, attribute.Index].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[8, attribute.Index].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    if (attribute.Width.HasValue)
                    {
                        sheet.Column(attribute.Index).Width = attribute.Width.Value;
                    }
                }
                continue;
            }
        }

        /// <summary>
        /// Tạo dữ liệu dòng
        /// </summary>
        /// <param name="data">dữ liệu</param>
        /// <param name="record">dòng excel</param>
        /// <param name="index">số thứ tự item</param>
        /// <param name="type">Kiểu dữ liệu</param>
        /// <param name="sheet"></param>
        /// <param name="isDrawColor">Tô màu cách dòng</param>
        /// <param name="isDateOnly">chỉ hiện thị ngày</param>
        private static void GenerateRow(ExportExcelModel data, int record, int index, ref ExcelWorksheet sheet, bool? isDrawColor = false, bool? isDateOnly = false)
        {
            var properties = data.GetType().GetProperties();

            sheet.Cells[record, 1].Value = index + 1;
            foreach (var property in properties)
            {
                var cell = GetCellData(property, data, isDateOnly);

                if (!cell.Column.Equals(0))
                {
                    sheet.Cells[record, cell.Column].Value = cell.CellData;

                    if (isDrawColor.Value && record % 2 == 0)
                    {
                        sheet.Cells[record, cell.Column].Style.Fill.SetBackground(Color.AliceBlue);
                    }

                    if (cell.Align.Equals(-1))
                    {
                        sheet.Cells[record, cell.Column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    }

                    if (cell.Align.Equals(0))
                    {
                        sheet.Cells[record, cell.Column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }

                    if (cell.Align.Equals(1))
                    {
                        sheet.Cells[record, cell.Column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    }
                }
                continue;
            }

            sheet.Rows[record].Height = 27;
        }


        private static (int Column, object CellData, int Align) GetCellData(PropertyInfo property, dynamic data, bool? isDateOnly = false)
        {
            var excelAttribute = property?.GetCustomAttributes(typeof(ExcelAttribute), false)?.FirstOrDefault();
            if (excelAttribute is null) return (0, default, default);
            var attribute = excelAttribute as ExcelAttribute;
            if (property.PropertyType.FullName.ToLower().Contains("decimal"))
            {
                var value = (decimal)property.GetValue(data);
                return (attribute.Index, value.ToCurrency(), 1);
            }

            return (attribute.Index, property.GetValue(data), -1);
        }
    }
}
