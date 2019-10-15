// JavaScript source code
/*
document.getElementById('ok').onclick = function () {
    var name = document.getElementById('name').value;
    var age = document.getElementById('age').value;

    var text = "Your name is " + name;
    text += " and you are" + age + " years old";

    document.getElementById('result').innerHTML = text;
    document.getElementById('ok').style.display = 'none';
};
*/

$(function () { // attēlot tikai tad, ja visa html lapa ir ielādēta
    $("#ok").click(function () {   //document.getElementById('ok').onclick = function () { (this is the same line)
        var name = $("#name").val(); //var name = document.getElementById('name').value; (also same line, and so on)
        var age = parseInt($("#age").val()); // izmantojam parseInt, lai zinatu, ka tas ir int
        age += 5;

        var text = "Your name is " + name;
        text += " and you are " + age + " years old";

        $("#result").html(text);
        $("#ok").hide();
    })
});

$(function () {
    $("#sum").click(function () {
        var number1 = parseInt($("#number1").val());
        var number2 = parseInt($("#number2").val());

        var resultsum = number1 + number2;
        var SUM = "Sum is " + resultsum;
       

        $("#result1").html(SUM);
        $("#sum").hide();
    })
});
$(function () {
    $("#diff").click(function () {
        var number1 = parseInt($("#number1").val());
        var number2 = parseInt($("#number2").val());

        var resultdiff = number1 - number2;
        var DIV = "Difference is " + resultdiff;
        

        $("#result1").html(DIV);
        $("#diff").hide();
    })
});