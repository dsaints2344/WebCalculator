var Calculator = new CalculatorConstructor();

function CalculatorConstructor() {

    this.Operate = function(element) {
        var text = $(element).text();

        $("#result").val(text);
        $("#result").text(text);
    };
};