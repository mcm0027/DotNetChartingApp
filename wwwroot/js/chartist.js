(function() {

    "use strict"
    var monthNum = 0;

    //occupancy data set

    var occupancy = [
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [95, 96, 98, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 60, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 50, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [100, 96, 80, 20]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [95, 96, 98, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 60, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 50, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [100, 96, 80, 20]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [95, 96, 98, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 60, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [98, 50, 99, 93]
    },
    {
    "Weeks": ['Week1', 'Week2', 'Week3', 'Week4'],
    "Percents": [100, 96, 80, 20]
    }
];


    // month picker functionality

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



    //line chart data and options
    function chart(monthNum) {
        new Chartist.Line('.ct-chart', {
            labels: occupancy[monthNum].Weeks,
            series: [occupancy[monthNum].Percents]
        }, {
            fullWidth: true,
            chartPadding: {
                right: 40
            }
        });
    }

})();