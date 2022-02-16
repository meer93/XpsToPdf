var xpsFileName = @"xpsFile";
Console.WriteLine("XPS to PDF conversion started");
PdfSharp.Xps.XpsConverter.Convert($"{xpsFileName}.XPS");
Console.WriteLine($"XPS to PDF conversion completed. File saved as {xpsFileName}.pdf");
