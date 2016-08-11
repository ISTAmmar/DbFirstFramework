var EcommerceIndex = function () {

    function showTooltip(x, y, labelX, labelY) {
        $('<div id="tooltip" class="chart-tooltip">' + (labelY.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, '$1,')) + 'USD<\/div>').css({
            position: 'absolute',
            display: 'none',
            top: y - 40,
            left: x - 60,
            border: '0px solid #ccc',
            padding: '2px 6px',
            'background-color': '#fff'
        }).appendTo("body").fadeIn(200);
    }

    var initChart1 = function () {

        var data = [
            ['01/2013', 4],
            ['02/2013', 8],
            ['03/2013', 10],
            ['04/2013', 12],
            ['05/2013', 2125],
            ['06/2013', 324],
            ['07/2013', 1223],
            ['08/2013', 1365],
            ['09/2013', 250],
            ['10/2013', 999],
            ['11/2013', 390]
        ];

            var previousPoint = null;

            $("#statistics_1").bind("plothover", function (event, pos, item) {
                $("#x").text(pos.x.toFixed(2));
                $("#y").text(pos.y.toFixed(2));
                if (item) {
                    if (previousPoint != item.dataIndex) {
                        previousPoint = item.dataIndex;

                        $("#tooltip").remove();
                        var x = item.datapoint[0].toFixed(2),
                            y = item.datapoint[1].toFixed(2);

                        showTooltip(item.pageX, item.pageY, item.datapoint[0], item.datapoint[1]);
                    }
                } else {
                    $("#tooltip").remove();
                    previousPoint = null;
                }
            });

    }

    var initChart2 = function() {

        var data = [
            ['01/2013', 10],
            ['02/2013', 0],
            ['03/2013', 10],
            ['04/2013', 12],
            ['05/2013', 212],
            ['06/2013', 324],
            ['07/2013', 122],
            ['08/2013', 136],
            ['09/2013', 250],
            ['10/2013', 99],
            ['11/2013', 190]
        ];

            var previousPoint = null;

            $("#statistics_2").bind("plothover", function (event, pos, item) {
                $("#x").text(pos.x.toFixed(2));
                $("#y").text(pos.y.toFixed(2));
                if (item) {
                    if (previousPoint != item.dataIndex) {
                        previousPoint = item.dataIndex;

                        $("#tooltip").remove();
                        var x = item.datapoint[0].toFixed(2),
                            y = item.datapoint[1].toFixed(2);

                       showTooltip(item.pageX, item.pageY, item.datapoint[0], item.datapoint[1]);
                    }
                } else {
                    $("#tooltip").remove();
                    previousPoint = null;
                }
            });

    }

    return {

        //main function
        init: function () {
            initChart1();

            $('#statistics_amounts_tab').on('shown.bs.tab', function (e) {
                initChart2();
            });
        }

    };

}();