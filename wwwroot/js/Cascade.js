$(document).ready(function () {


   //GetUnit();

    $('#UnitId').change(function () {
       
       

       var id = $('select#UnitId option:selected').val();
        const txt = JSON.stringify(id); 
        $('#RollId').empty();
        $('#RollId').append('<Option value=0 >--Select user type--</Option>');

   
   
        $.ajax({
            type: "POST",
            url: '/Login/GetRoll?UnitId=' + id,
            data: "",
            dataType: "json",
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $.each(result, function (i, data) {

                    const txt = JSON.stringify(data.roleOrder);
                    const txt1 = JSON.stringify(data.role);
                    const obj = JSON.parse(txt1);
                    $('#RollId').append('<Option value=' + txt + '>' + obj + '</Option>');
                });
            }
       });
    
    });

});
function GetUnit() {
    $('#ddUnit').empty();
    $('#ddUnit').append('<Option >--Select Department/Unit--</Option>');
    $.ajax({
        url: '/Login/Units',
        data: "",
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
         
            $.each(result, function (i, data) {
        
                const txt = JSON.stringify(data.subId);
                const txt1 = JSON.stringify(data.subject);
     
                const obj = JSON.parse(txt);
                const obj1 = JSON.parse(txt1);             
                $('#ddUnit').append('<Option value=' + obj + '>' + obj1 + '</Option>');
            });

        }
    });
}


   
