﻿
//FusionCharts.ready(function () {
//    var revenueChart = new FusionCharts({
//        "type": "column2d",
//        "renderAt": "chartContainer",
//        "width": "700",
//        "height": "400",
//        "dataFormat": "json",
//        "dataSource": {
//            "chart": {
//                "caption": "Monthly revenue for last year",
//                "subCaption": "Harry's SuperMart",
//                "xAxisName": "Month",
//                "yAxisName": "Revenues (In USD)",
//                "theme": "fint"
//            },
//            "data": [
//                {
//                    "label": "Jan",
//                    "value": "420000"
//                },
//                {
//                    "label": "Feb",
//                    "value": "810000"
//                },
//                {
//                    "label": "Mar",
//                    "value": "720000"
//                },
//                {
//                    "label": "Apr",
//                    "value": "550000"
//                },
//                {
//                    "label": "May",
//                    "value": "910000"
//                },
//                {
//                    "label": "Jun",
//                    "value": "510000"
//                },
//                {
//                    "label": "Jul",
//                    "value": "680000"
//                },
//                {
//                    "label": "Aug",
//                    "value": "620000"
//                },
//                {
//                    "label": "Sep",
//                    "value": "610000"
//                },
//                {
//                    "label": "Oct",
//                    "value": "490000"
//                },
//                {
//                    "label": "Nov",
//                    "value": "900000"
//                },
//                {
//                    "label": "Dec",
//                    "value": "730000"
//                }
//            ]
//        }
//    });

//    revenueChart.render();

(function () {

    //"use strict"
    //var monthNum = 0;

    //$('.monthPicker').datepicker({
    //    autoclose: true,
    //    minViewMode: 1,
    //    format: 'mm/yyyy'
    //}).on('changeDate', function (selected) {
    //    selectedMonth = new Date(selected.date.valueOf());
    //    selectedMonth.setDate(selectedMonth.getDate(new Date(selected.date.valueOf())));
    //    console.log("selected month " + selectedMonth.getMonth());
    //    monthNum = selectedMonth.getMonth();
    //    chart(monthNum);
    //});

    new Chartist.Pie('.ct-chart', {
        series: [10, 2, 4, 3]
    }, {
        donut: true
    });
})();
