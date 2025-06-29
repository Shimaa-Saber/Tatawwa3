//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;
//using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
//using QuestPDF.Drawing;

//namespace Tatawwa3.Application.Services
//{
//    public class GenerateCertificatePdfService
//    {
//        public byte[] GenerateCertificatePdf(CertificateDto dto)
//        {
//            var document = Document.Create(container =>
//            {
//                container.Page(page =>
//                {
//                    page.Size(PageSizes.A4);
//                    page.Margin(2, Unit.Centimetre);
//                    page.DefaultTextStyle(x => x.FontSize(20));

//                    page.Content().Column(col =>
//                    {
//                        col.Item().Text("شهادة شكر وتقدير").SemiBold().FontSize(30).AlignCenter();
//                        col.Item().PaddingVertical(15).Text($"نُشْهِد بأن {dto.VolunteerName} قد شارك في {dto.OpportunityTitle}.");
//                        col.Item().Text($"عدد الساعات: {dto.TotalHours} ساعة");
//                        col.Item().Text($"تاريخ الإصدار: {dto.IssueDate:yyyy-MM-dd}");
//                        col.Item().Text($"رقم الشهادة: {dto.CertificateNumber}");
//                    });
//                });
//            });

//            return document.GeneratePdf();
//        }

//    }
//}
