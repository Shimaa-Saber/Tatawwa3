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
        //public byte[] GenerateCertificatePdf(Certificate certificate)
        //{
        //    QuestPDF.Settings.License = LicenseType.Community;
        //    var bytes = Document.Create(container =>
        //    {
        //        container.Page(page =>
        //        {
        //            page.Size(PageSizes.A4);
        //            page.Margin(2, Unit.Centimetre);
        //            page.DefaultTextStyle(x => x.FontSize(16));
        //            page.Content()
        //                .Column(col =>
        //                {
        //                    col.Spacing(15);

        //                    col.Item().Text("شهادة مشاركة").FontSize(24).Bold().AlignCenter();
        //                    col.Item().Text($"المتطوع: {certificate.Volunteer?.User?.FullName ?? "غير معروف"}");
        //                    col.Item().Text($"عنوان الفرصة: {certificate.Participation?.Opportunity?.Title}");
        //                    col.Item().Text($"عدد الساعات: {certificate.TotalHours}");
        //                    col.Item().Text($"تاريخ الإصدار: {certificate.IssueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}");
        //                    col.Item().Text($"الجهة: {certificate.Participation?.Opportunity?.Organization?.OrganizationName}");
        //                    col.Item().Text($"رقم الشهادة: {certificate.CertificateNumber}");
        //                    col.Item().Text($"رمز التحقق: {certificate.VerificationCode}");
        //                });
        //        });
        //    }).GeneratePdf();

        //    return bytes;
        //}

        public byte[] GenerateCertificatePdf(Certificate certificate)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var bytes = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1.5f, Unit.Centimetre);
                    page.PageColor("#FFFBEA"); // خلفية ذهبية خفيفة
                    page.DefaultTextStyle(x => x.FontSize(16).FontFamily("Arial"));

                    page.Content().Border(2).BorderColor(Colors.Grey.Medium).Padding(30).Column(col =>
                    {
                        col.Spacing(20);

                        // اللوجو + عنوان الشهادة
                        col.Item().Row(row =>
                        {
                            row.ConstantColumn(80).Image("wwwroot/images/logo.png", ImageScaling.FitWidth); // عدلي المسار حسب مكان اللوجو
                            row.RelativeColumn().AlignCenter().Text("شهادة مشاركة")
                                .FontSize(30).Bold().FontColor("#C4962F"); // ذهبي رسمي
                        });

                        col.Item().AlignCenter().Text("تُمنح هذه الشهادة لـ").FontSize(18).Italic().FontColor("#444");

                        col.Item().AlignCenter().Text(certificate.Volunteer?.User?.FullName ?? "غير معروف")
                            .FontSize(24).Bold().FontColor(Colors.Black);

                        col.Item().AlignCenter().Text($"لمشاركته في الفرصة \"{certificate.Participation?.Opportunity?.Title}\"")
                            .FontSize(18).FontColor("#444");

                        col.Item().PaddingTop(10).Column(innerCol =>
                        {
                            innerCol.Spacing(8);

                            innerCol.Item().Text($"عدد الساعات: {certificate.TotalHours}");
                            innerCol.Item().Text($"تاريخ الإصدار: {certificate.IssueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}");
                            innerCol.Item().Text($"الجهة المنظمة: {certificate.Participation?.Opportunity?.Organization?.OrganizationName}");
                            innerCol.Item().Text($"رقم الشهادة: {certificate.CertificateNumber}");
                            innerCol.Item().Text($"رمز التحقق: {certificate.VerificationCode}");
                        });

                        col.Item().PaddingTop(30).AlignRight().Text("مع أطيب التحيات،").FontSize(14).Italic();
                        col.Item().AlignRight().Text("منصة تطوع").FontSize(16).Bold().FontColor("#C4962F");
                    });

                    page.Footer().AlignCenter().Text("جميع الحقوق محفوظة © منصة تطوع").FontSize(10).FontColor(Colors.Grey.Darken2);
                });
            }).GeneratePdf();

            return bytes;
        }

    }

}
