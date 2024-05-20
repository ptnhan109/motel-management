import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/services/app.service';


import {
  ChartComponent,
  ApexAxisChartSeries,
  ApexNonAxisChartSeries,
  ApexChart,
  ApexXAxis,
  ApexDataLabels,
  ApexStroke,
  ApexYAxis,
  ApexLegend,
  ApexFill,
  ApexGrid,
  ApexPlotOptions,
  ApexTooltip,
  ApexMarkers,
  ApexTheme
} from 'ng-apexcharts';

export type ChartOptions = {
  series: ApexAxisChartSeries | ApexNonAxisChartSeries;
  chart: ApexChart;
  xaxis: ApexXAxis;
  stroke: ApexStroke;
  dataLabels: ApexDataLabels;
  plotOptions: ApexPlotOptions;
  yaxis: ApexYAxis;
  tooltip: ApexTooltip;
  labels: string[];
  colors: string[];
  legend: ApexLegend;
  fill: ApexFill;
  grid: ApexGrid;
  markers: ApexMarkers;
  theme: ApexTheme;
};
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  summary =
    {
      totalRooms: 6,
      totalRoomHired: 2,
      totalCustomer: 0,
      totalRoomDeposited: 2,
      totalDepositedAmount: 0,
      totalRoomPending: 1
    }

  chartOptions!: Partial<ChartOptions>;
  chartOptions_2!: Partial<ChartOptions>;
  constructor(
    private _service: AppService
  ) { }

  ngOnInit(): void {
    this.Init();


    this.chartOptions = {
      chart: {
        height: 205,
        type: 'bar',
        toolbar: {
          show: false
        }
      },
      dataLabels: {
        enabled: false
      },
      stroke: {
        width: 2,
        curve: 'smooth'
      },
      series: [
        {
          name: 'Arts',
          data: [20, 50, 30, 60, 30, 50]
        }
      ],
      legend: {
        position: 'top'
      },
      xaxis: {
        type: 'category',
        categories: ['1/11/2000', '2/11/2000', '3/11/2000', '4/11/2000', '5/11/2000', '6/11/2000'],
        axisBorder: {
          show: false
        }
      },
      yaxis: {
        show: true,
        min: 10,
        max: 70
      },
      colors: ['#73b4ff', '#59e0c5'],
      fill: {
        type: 'gradient',
        gradient: {
          shade: 'light',
          gradientToColors: ['#4099ff', '#2ed8b6'],
          shadeIntensity: 0.5,
          type: 'horizontal',
          opacityFrom: 1,
          opacityTo: 1,
          stops: [0, 100]
        }
      },
      grid: {
        borderColor: '#cccccc3b'
      }
    };

    this.chartOptions_2 = {
      chart: {
        height: 150,
        type: 'donut'
      },
      dataLabels: {
        enabled: false
      },
      plotOptions: {
        pie: {
          donut: {
            size: '75%'
          }
        }
      },
      labels: ['Phòng trống', 'Đã cho thuê'],
      series: [20, 15],
      legend: {
        show: false
      },
      tooltip: {
        theme: 'dark'
      },
      grid: {
        padding: {
          top: 20,
          right: 0,
          bottom: 0,
          left: 0
        }
      },
      colors: ['#f79a05', '#2ed8b6'],
      fill: {
        opacity: [1, 1]
      },
      stroke: {
        width: 0
      }
    };
  }

  Init() {
    this._service.getDashboardStagePayment().subscribe((response) => {
      if (response.isSucceeded) {

        let values =  (response.data as any[]).map(x => x.value);
        let series = {
          name : 'Doanh thu',
          data : values
        };
        this.chartOptions.series = [series];
        this.chartOptions.xaxis.categories = (response.data as any[]).map(x => x.label);
        console.log(this.chartOptions);
      }
    })

    this._service.getDashboardSummary().subscribe((response) => {
      if (response.isSucceeded) {
        this.summary = response.data;
        this.chartOptions_2.series = [this.summary.totalRoomPending, this.summary.totalRoomHired]
      }
    })

    
  }

}
