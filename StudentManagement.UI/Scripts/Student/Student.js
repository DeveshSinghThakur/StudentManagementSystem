
$(function () {

    GetAllStudents();

})


function GetAllStudents() {


    //api call
    $.get(ConstantValues.APIPath +"/api/Student", function (students) {


        //iterate student and assing to html
        var studentHtml = "";
        $.each(students, function (index, student) {

            studentHtml += "<tr>";
            studentHtml += "<td>" + student.Id + "</td>";
            studentHtml += "<td>" + student.Name + "</td>";
            studentHtml += "<td>" + student.EmailId + "</td>";
            studentHtml += "</tr>";


        });

        //add html to Ui
        $("#studentsBody").html(studentHtml);

    });


}