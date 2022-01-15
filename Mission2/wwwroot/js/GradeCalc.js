//John Berthelsen
//Mission #2 Grade Calculator
$("#btnCalc").click(function () {

//Calculate Total Grade
    let iAssignment = $("#AssignmentsPct").val() * 0.55;
    let iGroupProject = $("#GroupProjectPct").val() * 0.05;
    let iQuizzes = $("#QuizzesPct").val() * 0.10;
    let iExams = $("#ExamsPct").val() * 0.20;
    let iINTEX = $("#INTEXPct").val() * 0.10;
    let iTotal = iAssignment + iGroupProject + iQuizzes + iExams + iINTEX
    iTotal = iTotal.toFixed(2)

//Assign Letter Grade
    if (iTotal >= 94) {
        sGrade = "A";
    } else if (iTotal >= 90) {
        sGrade = "A-";
    } else if (iTotal >= 87) {
        sGrade = "B+"
    } else if (iTotal >= 84) {
        sGrade = "B"
    } else if (iTotal >= 80) {
        sGrade = "B-"
    } else if (iTotal >= 77) {
        sGrade = "C+"
    } else if (iTotal >= 74) {
        sGrade = "C"
    } else if (iTotal >= 70) {
        sGrade = "C-"
    } else if (iTotal >= 67) {
        sGrade = "D+"
    } else if (iTotal >= 64) {
        sGrade = "D"
    } else if (iTotal >= 60) {
        sGrade = "D-"
    } else {
        sGrade = "E"
    }

//Display Grade Percentage and Letter
    alert("Your final grade percentage is: " + iTotal + "%. Your final grade is a(n) " + sGrade)
});
