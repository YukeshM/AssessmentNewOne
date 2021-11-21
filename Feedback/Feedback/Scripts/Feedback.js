$(document).ready(function () {

    $.ajax({
        type: "GET",
        url: "/Feedback/GetCategory",
        success: function (CategoryList) {
            $.each(CategoryList, function (index, category) {
                let categoryOption = "categoryOption";
                $("#Category").append('<option value ="' + category.CategoryId + '" id = "' + categoryOption + '" >' + category.CategoryName + '</option>');
            });
        }
    });

    //for getting product with respective category
    $("#Product").click(function () {
        let categoryId = $("#Category option:selected").attr("value");
        console.log(categoryId);
        $("#Product").each(function () {
            $("#Product option").data('<option value =""></option>');
        });
        if (categoryId == 0) {
            alert("choose a category");
        }
        $.ajax({
            type: "GET",
            url: "/Feedback/GetProductByCategoryId/" + categoryId,
            success: function (ProductList) {
                $.each(ProductList, function (index, product) {
                    $("#Product").append('<option value = "' + product.ProductId + '" >' + product.ProductName +
                        '</option>');
                })
            }
        });
    });

    $.ajax({
        type: "GET",
        url: "/Feedback/GetTitle",
        success: function (TitleList) {
            $.each(TitleList, function (index, Title) {
                $("#Title").append('<option value="' + Title.TitleId + '">' + Title.TitleName +
                    '</option>');
            });
        }
    });

    $.ajax({
        type: "GET",
        url: "/Feedback/GetCountry",
        success: function (CountryList) {
            $.each(CountryList, function (index, Country) {
                $("#Country").append('<option value = "' + Country.CountryId + '">' + Country.CountryName + '</option>');
            });
        }
    });


    //validate category
    $("#CategoryCheck").hide();
    let categoryError = true;
    $("#CategoryCheck").mouseout(function () {
        ValidateCategory();
    });


    function ValidateCategory() {
        let category = $("#CategoryCheck").attr("value");
        if (category == 0) {
            $("#CategoryCheck").show();
            categoryError = false;
        }
    };

    //validate product
    $("#ProductCheck").hide();
    let ProductError = true;
    $("#Product").mouseout(function () {
        ValidateCategory();
    });

    function ValidateCategory() {
        let category = $("#ProductCheck").attr("value");
        if (category == 0) {
            $("#ProductCheck").show();
            categoryError = false;
        }
    };

    //validate satisfication
    $("#SatisfactoryCheck").hide();
    let satisfactionError = true;
    $("#Satisfactory").val(null)

    //validate purchased in last two month
    $("#PurchasedProductInLastTwoMonthCheck").hide();

    //comment
    $("#CommentCheck").hide();
    let commentError = true;
    $("#Comment").keyup(function () {
        ValidateComment();
    });

    function ValidateComment() {
        let comment = $("#Comment").val();
        console.log(comment);
        if (comment == "") {
            $("#CommentCheck").show();
            commentError = false;
        }
        else if (comment.length < 3 || comment.length > 250) {
            $("#CommentCheck").show();
            $("#CommentCheck").html("comment should not be less than 3 and should not be greater than 250");
            commentError = false;
        }
        else {
            $("#CommentCheck").hide();
            commentError = true;
        }
    }

    //validate title
    $("#TitleCheck").hide();

    //validate first name
    $("#FirstNameCheck").hide();
    let firstNameError = true;
    $("#FirstName").keyup(function () {
        validateName();
    });

    function validateName() {
        let firstName = document.getElementById('FirstName');

        if (firstName.value == "") {
            $("#FirstNameCheck").show();
            firstNameError = false;
        }
        else if ((firstName.value.length < 3) || (firstName.value.length > 50)) {
            $("#FirstNameCheck").show();
            $("#FirstNameCheck").html("length of the name should be between 3 and 50");
            firstNameError = false;
        }
        else {
            $("#FirstNameCheck").hide();
            firstNameError = true;
        }
    }

    //validate initial
    $("#InitialCheck").hide();
    let initialError = true;
    $("#Initial").keyup(function () {
        ValidateInitial();
    });

    function ValidateInitial() {
        let initial = document.getElementById('Initial');

        if (initial.value == "") {
            $("#InitialCheck").show();
            initialError = false;
        }
        else if (initial.value.length > 5) {
            $("#InitialCheck").show();
            $("#InitialCheck").html("length of the initial should be less than 5");
            initialError = false;
        }
        else {
            $("#InitialCheck").hide();
            initialError = true;
        }
    }

    //validate email
    $("#EmailCheck").hide();

    //validate street address
    $("#StreetAddressCheck").hide();
    let streetAddressError = true;
    $("#StreetAddress").keyup(function () {
        ValidateStreetAddress();
    });

    function ValidateStreetAddress() {
        let streetAddress = $("#StreetAddress").val();
        if (streetAddress == "") {
            $("#StreetAddressCheck").show();
            streetAddressError = false;
        }
        else if (streetAddress.length < 3 || streetAddress.length > 50) {
            $("#StreetAddressCheck").show();
            $("#StreetAddressCheck").html("streetAddress should not be less than 3 and should not be greater than 50");
            streetAddressError = false;
        }
        else {
            $("#StreetAddressCheck").hide();
            streetAddressError = true;
        }
    }


    //validate city
    $("#CityCheck").hide();
    let cityError = true;
    $("#City").keyup(function () {
        ValidateCity();
    });

    function ValidateCity() {
        let city = $("#City").val();
        if (city == "") {
            $("#CityCheck").show();
            cityError = false;
        }
        else if (city.length < 3 || city.length > 50) {
            $("#CityCheck").show();
            $("#CityCheck").html("city should not be less than 3 and should not be greater than 50");
            cityError = false;
        }
        else {
            $("#CityCheck").hide();
            cityError = true;
        }
    }

    //validate region
    $("#RegionCheck").hide();
    let regionError = true;
    $("#Region").keyup(function () {
        ValidateRegion();
    });

    function ValidateRegion() {
        let region = $("#Region").val();
        if (region == "") {
            $("#RegionCheck").show();
            regionError = false;
        }
        else if (region.length < 3 || region.length > 50) {
            $("#RegionCheck").show();
            $("#RegionCheck").html("Region should not be less than 3 and should not be greater than 50");
            regionError = false;
        }
        else {
            $("#RegionCheck").hide();
            regionError = true;
        }
    }

    //for validating zipcode
    $("#ZipcodeCheck").hide();
    let zipcodeError = true;
    $("#Zipcode").keyup(function () {
        validateZipcode();
    });

    function validateZipcode() {
        let zipcode = $("#Zipcode").val();
        if (zipcode == "") {
            $("#ZipcodeCheck").show();
            zipcodeError = false;
        }
        else if (zipcode > 999999) {
            $("#ZipcodeCheck").show();
            $("#ZipcodeCheck").html("zipcode/postal code should not be greater than 999999");
            zipcodeError = false;
        }
        else {
            $("#ZipcodeCheck").hide();
            zipcodeError = true;
        }
    }

    //validate country
    $("#CountryCheck").hide();

    //validate reason
    $("#ReasonCheck").hide();
    let reasonError = true;
    $("#Reason").keyup(function () {
        ValidateReason();
    });

    function ValidateReason() {
        let reason = $("#Reason").val();
        if (reason == "") {
            $("#ReasonCheck").show();
            reasonError = false;
        }
        else if (reason.length < 3 || reason.length > 250) {
            $("#ReasonCheck").show();
            $("#ReasonCheck").html("Reason should not be less than 3 and should not be greater than 250");
            reasonError = false;
        }
        else {
            $("#ReasonCheck").hide();
            reasonError = true;
        }
    }

    //validate file
    $("#FileCheck").hide();
    let fileError = true;
    $("#File").change(function () {
        ValidateFile();
    });

    function ValidateFile() {
        let file = $("#File");
        file = file[0].files[0];

        if (file) {
            if (file.type.split("/")[1] !== "pdf" || !(file.size < 500000)) {
                $("#FileCheck").html("upload resume less than 500KB and in pdf format");
                $("#FileCheck").show();
                document.getElementById("File").value = "";
                fileError = false;
            }
            else {
                fileError = true;
            }
        }
        else {
            $("#FileCheck").show();
            $("#FileCheck").html("upload resume less than 500KB and in pdf format");
            fileError = false;

        }
    };


    //create feedback
    $("#btnSubmit").click(function () {
        validateName()
        if (firstNameError == true) {
            $.ajax({
                type: "POST",
                url: "/Feedback/Create",
                data: {
                    Category: $("#Category").val(),
                    Product: $("#Product").val(),
                    Country: $("#Country").val(),
                    Satisfactory: $("#Satisfactory").val(),
                    Title: $("#Title").val(),
                    Product2: $("#PurchasedProductInLastTwoMonth").val(),
                    Comment: $("#Comment").val(),
                    FirstName: $("#FirstName").val(),
                    Initial: $("#Initial").val(),
                    StreetAddress: $("#StreetAddress").val(),
                    StreetAddressLine: $("#StreetAddressLine2").val(),
                    City: $("#City").val(),
                    Region: $("#Region").val(),
                    Reason: $("#Reason").val(),
                    FeedbackFile: $("#File").val(),
                    Zipcode: $("#Zipcode").val()                
                },
                success: function () {
                    alert("Feedback submitted successfully!");
                }
            });
        }
        else {
            alert("Error occured");
        }

    });




});
