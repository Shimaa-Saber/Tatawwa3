using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.Services
{
    public class PdfGenerator : IPdfGenerator
    {
        public byte[] GenerateCertificatePdf(Certificate certificate)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var bytes = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(16));
                    page.Content()
                        .Column(col =>
                        {
                            col.Spacing(15);

                            col.Item().Text("شهادة مشاركة").FontSize(24).Bold().AlignCenter();
                            col.Item().Text($"المتطوع: {certificate.Volunteer?.User?.FullName ?? "غير معروف"}");
                            col.Item().Text($"عنوان الفرصة: {certificate.Participation?.Opportunity?.Title}");
                            col.Item().Text($"عدد الساعات: {certificate.TotalHours}");
                            col.Item().Text($"تاريخ الإصدار: {certificate.IssueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}");
                            col.Item().Text($"الجهة: {certificate.Participation?.Opportunity?.Organization?.OrganizationName}");
                            col.Item().Text($"رقم الشهادة: {certificate.CertificateNumber}");
                            col.Item().Text($"رمز التحقق: {certificate.VerificationCode}");
                        });
                });
            }).GeneratePdf();

            return bytes;
        }
    }

}
