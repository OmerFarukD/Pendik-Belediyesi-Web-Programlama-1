namespace Encapsulation;
// kitap -> Başlığı , Açıklaması , Yazar Adı, Yazar Soyadı,
// Yayın evi ,Basım Tarihi ,
//Yazar Tam adı,  (Yayın evi - Basım Tarihi)
public class Book
{
    public string Title { get; set; }
    public string Description { get; set; }

    public string AuthorName { get; set; }

    public string AuthorSurname { get; set; }

    public string Publisher { get; set; }

    public string PublishDate { get; set; }

    public string AuthorFullName => $"{AuthorName} {AuthorSurname}";

    public string PublishInfo => $"{Publisher} - {PublishDate}";

    public override string ToString()
    {
        return $"Başlık : {Title}, Açıklama : {Description}" +
            $"Yazar Adı: {AuthorName}, Yazar Soyadı: {AuthorSurname}" +
            $"Yayın Evi : {Publisher}, Basım Tarihi : {PublishDate}" +
            $"Yayın Evi info : {PublishInfo}, Yazar Full adı : {AuthorFullName}";
    }
}
