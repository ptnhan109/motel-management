import { formatDate } from "@angular/common";
import * as moment from "moment";
import { environment } from "src/environments/environment";

export function FormatCurrency(input) {
    return input.toFixed(0).replace(/(.)(?=(\d{3})+$)/g, '$1.');
}

export function RemoveNullable(obj) {
    return Object.entries(obj)
        .filter(([_, v]) => v != null)
        .reduce((acc, [k, v]) => ({ ...acc, [k]: v }), {});
}

export function SetPropertyToNull(obj) {
    Object.keys(obj).forEach(function (index) {
        obj[index] = null
    });
}

export function GetAvatar(avatar) {
    if (avatar == null || avatar == undefined || avatar == "") {
        return `${environment.apiServer}/Files/Images/avatar-default.jpg`
    }

    return `${environment.apiServer}/Files/${avatar}`
}

export function GetCareer(career) {
    if (career == null) {
        return null;
    }
    switch (career) {
        case 1:
            return "Sinh viên";
        case 2:
            return "Người đi làm";
        default:
            return "";
    }
}

export function toDateFormat(date) {
    let format = 'dd/MM/yyyy';
    let locale = 'en-US';
    return formatDate(date, format, locale);
}

export function GetCurrentDate() {
    const format = "YYYY-MM-DD";
    return moment().format(format);
}

// Function to convert an object to URL parameters
export function ToUrlParam(model: any) {
    let data = RemoveNullable(model);
    let params = Object.keys(data)
      .map(
        key => Array.isArray(data[key]) ?
          data[key].map(v => `${key}=${v}`).join('&') :
          `${key}=${data[key]}`
      )
      .join('&');
    return `?${params}`
  }
  