function DeleteItem(id) {
    var url = $('#remove-link-' + id).attr('data-url');
    console.log(url);
    $.ajax({
        url: url, // Silme işlemi için URL
        type: 'POST', // HTTP yöntemi (POST)
        data: {
            // __RequestVerificationToken: $('input[name="__RequestVerificationToken"]').val(), // CSRF koruma token'ı
            id: id // Silinecek kategori ID'si
        },
        success: function (response) {
            // Başarılı olursa sayfayı yenile
            location.reload();
        },
        error: function (xhr, status, error) {
            // Hata alındığında kullanıcıya mesaj göster
            alert('Silme işlemi başarısız oldu: ' + error);
        }
    });
}