
function newfunction(index) {
    const checkbox = document.getElementById("ch_" + index);
    const textbox = document.getElementById("ans_" + index);
    const labelbox = document.getElementById("lab_" + index);

    checkbox.addEventListener("change", function () {
        if (this.checked) {
            textbox.style.display = "block";
            labelbox.style.display = "none";
            checkbox.style.display = "none";

        } else {
            textbox.style.display = "none";
            labelbox.style.display = "block";
        }
    });
}


//    function validateForm(index) {
//        var required = document.forms["item-" + index]["isrequired"].value;
//        if (required == "true") {
//            var x = document.forms["item-" + index]["input_" + index].value;
//            if (x == "") {
//                alert("Answer cannot be empty");
//                return false;
//            }
//            else {
//                return true;
//            }
//        }
//        else {
//            return true;
//        }
//}
//function validateForm2(index) {
//    var required = document.forms["item2-" + index]["isrequired"].value;
//    if (required == "true") {
//        var checkbox1 = document.getElementById("op1_" + index);
//        var checkbox2 = document.getElementById("op2_" + index);
//        var checkbox3 = document.getElementById("op3_" + index);
//        var checkbox4 = document.getElementById("op4_" + index);
//        var checkbox5 = document.getElementById("op5_" + index);
//        var answerbox = document.forms["item2-" + index]["ans_" + index].value;
//        if (checkbox1.checked == true || checkbox2.checked == true || checkbox3.checked == true || checkbox4.checked == true || checkbox5.checked == true) {
//            return true;
//        }
//        else if (answerbox != "") {
//            return true;
//        }
//        else {
//            alert("choose atleast 1 option Or write Answer in Other option");
//            return false;
//        }
//    }
//    else {
//        return true;
//    }

//}
function newfunction(index) {
    const checkbox = document.getElementById("ch_" + index);
    const textbox = document.getElementById("ans_" + index);
    const labelbox = document.getElementById("lab_" + index);

    checkbox.addEventListener("change", function () {
        if (this.checked) {
            textbox.style.display = "block";
            labelbox.style.display = "none";
            checkbox.style.display = "none";

        } else {
            textbox.style.display = "none";
            labelbox.style.display = "block";
        }
    });
}

function ButtonClick(index) {
    document.getElementById("in_" + index).style.display = "block";
    document.getElementById("b_" + index).style.display = "none";
}

