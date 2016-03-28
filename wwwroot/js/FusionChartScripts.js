

(function () {

    "use strict"
    var monthNum = 0;

    //new to old data set

    var percentages = [
        {
            "Percents": [90, 4, 6],
            "Month": "January"
        },
        {
            "Percents": [80, 10, 10],
            "Month": "February"
        },
        {
            "Percents": [30, 60, 10],
            "Month": "March"
        },
        {
            "Percents": [6, 4, 90],
            "Month": "April"
        },
        {
            "Percents": [90, 4, 6],
            "Month": "May"
        },
        {
            "Percents": [30, 60, 10],
            "Month": "June"
        },
        {
            "Percents": [90, 4, 6],
            "Month": "July"
        },
        {
            "Percents": [30, 60, 10],
            "Month": "August"
        },
        {
            "Percents": [90, 4, 6],
            "Month": "September"
        },
        {
            "Percents": [90, 4, 6],
            "Month": "October"
        },
        {
            "Percents": [30, 60, 10],
            "Month": "November"
        },
        {
            "Percents": [90, 4, 6],
            "Month": "December"
        }
    ];

    //monthpicker functionality

    var selectedMonth = new Date();

    $('.monthPicker').datepicker({
        autoclose: true,
        minViewMode: 1,
        format: 'mm/yyyy'
    }).on('changeDate', function (selected) {
        selectedMonth = new Date(selected.date.valueOf());
        selectedMonth.setDate(selectedMonth.getDate(new Date(selected.date.valueOf())));
        console.log("selected month " + selectedMonth.getMonth());
        monthNum = selectedMonth.getMonth();
        chart(monthNum);
    });

    function chart(monthNum) {
        new Chartist.Pie('.ct-chart', {
            series: percentages[monthNum].Percents
        }, {
            donut: true
        });
    };
})();
