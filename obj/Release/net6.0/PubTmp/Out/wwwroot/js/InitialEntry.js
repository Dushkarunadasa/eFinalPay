$(document).ready(function () {

    $('#submit').prop('disabled', false);


    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus')
    })

    $('#BankCode').change(function () {      

        var id = $('select#BankCode option:selected').val();
        var SysCode = $('select#SysCode option:selected').text();
        var CatCode = $('select#CatCode option:selected').text()
        var OfficialNo = $('#OfficialNo').val();

       
        const txt = JSON.stringify(id);
        $('#BranchCode').empty();
        $('#BranchCode').append('<Option value=0 >--Select Branch--</Option>');
        $.ajax({
            type: "POST",
            url: '/PayOffice/GetBankBrnach?BankCode=' + id + '&&SysCode=' + SysCode + '&&CatCode=' + CatCode + '&&OfficialNo=' + OfficialNo ,
            data: "",
            dataType: "json",
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $.each(result, function (i, data) {

                   

                    const txt = JSON.stringify(data.branchCode);
                    const txt1 = JSON.stringify(data.branchName);
                    const obj = JSON.parse(txt1);
                    $('#BranchCode').append('<Option value=' + txt + '>' + obj + '</Option>');
                })
            }
        });

    });


    $('#BranchCode').change(function () {
      

        $("#yourdropdownid option:selected").text();
    
        var SysCode = $('select#SysCode option:selected').text();
        var CatCode = $('select#CatCode option:selected').text();
        var OfficialNo = $('#OfficialNo').val();      
        var BankCode = $('select#BankCode option:selected').val();
        var BranchCode = $('select#BranchCode option:selected').val();   

        
        $('#AccountNo').empty();
        $('#AccountNo').append('<Option value=0 >--Select Account--</Option>');

        
   
        $.ajax({
            type: "POST",
            url: '/PayOffice/GetBankAccount?SysCode=' + SysCode + '&catCode=' + CatCode + '&OfficialNo=' + OfficialNo + '&BankCode=' + BankCode + '&BranchCode=' + BranchCode,
            data: "",
            dataType: "json",
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $.each(result, function (i, data) {
                    const txt = JSON.stringify(data.accNo);
                    const txt1 = JSON.stringify(data.accNo);
                    const obj = JSON.parse(txt1);
                    $('#AccountNo').append('<Option value=' + txt + '>' + obj + '</Option>');
                })
            }
        });

    });
})
