using System;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    interface iReport
    {
        void Report(DataGridView info, User _user);
    }

    class Secretary : User, iReport
    {
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;

        public Secretary()
        {

        }

        internal override string sendRules()
        {
            base.sendRules();
            string res = "secretary";
            return res;
        }

        public void Report(DataGridView info, User _user)
        {
            application = new Application
            {
                DisplayAlerts = false
            };
            const string template = "template.xlsm";
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));
            worksheet = workBook.ActiveSheet as Worksheet;
            int cellRowIndex = 1;
            int cellColumnIndex = 1;

            for (int i = 0; i < info.Rows.Count; i++)
            {
                for (int j = 0; j < info.Columns.Count; j++)
                {
                    if (cellRowIndex.Equals(1)) { worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(); cellRowIndex++; cellColumnIndex = 0; }
                    else if (cellRowIndex.Equals(2)) { worksheet.Cells[cellRowIndex, cellColumnIndex] = "REPORT by Secretary: " + _user.username; cellRowIndex++; cellColumnIndex = 0; j -= 2; }
                    else if (cellRowIndex.Equals(3))
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Columns[j].HeaderText;
                        rng.Font.Color = XlRgbColor.rgbAntiqueWhite;
                        rng.Interior.Color = XlRgbColor.rgbCadetBlue;
                    }
                    else
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Rows[i - 1].Cells[j].Value.ToString();
                        rng.Font.Color = XlRgbColor.rgbBlack;
                        rng.Interior.Color = XlRgbColor.rgbLightGray;
                        rng.Borders[XlBordersIndex.xlInsideVertical].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeLeft].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeRight].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeBottom].Weight = 2d;

                    }
                    cellColumnIndex++;
                }
                cellColumnIndex = 1;
                cellRowIndex++;
            }
            application.Visible = true;
            string savedFileName = passGen() + DateTime.Now.ToString("HHmmss") + ".xlsm";
            string basePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string fullPath = basePath + "\\reports\\" + savedFileName;
            workBook.SaveAs(fullPath);
            while (application.Visible) { }
            CloseExcel();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);

        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);
                application = null;
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }
    }

    class Administrator : User, iReport
    {
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;

        public Administrator()
        {

        }

        internal override string sendRules()
        {
            base.sendRules();
            string res = "admin";
            return res;
        }

        public void Report(DataGridView info, User _user)
        {
            application = new Application
            {
                DisplayAlerts = false
            };
            const string template = "template.xlsm";
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));
            worksheet = workBook.ActiveSheet as Worksheet;
            int cellRowIndex = 1;
            int cellColumnIndex = 1;

            for (int i = 0; i < info.Rows.Count; i++)
            {
                for (int j = 0; j < info.Columns.Count; j++)
                {
                    if (cellRowIndex.Equals(1)) { worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(); cellRowIndex++; cellColumnIndex = 0; }
                    else if (cellRowIndex.Equals(2)) { worksheet.Cells[cellRowIndex, cellColumnIndex] = "REPORT by Administrator: " + _user.username; cellRowIndex++; cellColumnIndex = 0; j -= 2; }
                    else if (cellRowIndex.Equals(3))
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Columns[j].HeaderText;
                        rng.Font.Color = XlRgbColor.rgbGhostWhite;
                        rng.Interior.Color = XlRgbColor.rgbLightSeaGreen;
                    }
                    else
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Rows[i - 1].Cells[j].Value.ToString();
                        rng.Font.Color = XlRgbColor.rgbBlack;
                        rng.Interior.Color = XlRgbColor.rgbLightGray;
                        rng.Borders[XlBordersIndex.xlInsideVertical].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeLeft].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeRight].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeBottom].Weight = 2d;

                    }
                    cellColumnIndex++;
                }
                cellColumnIndex = 1;
                cellRowIndex++;
            }
            application.Visible = true;
            string savedFileName = passGen() + DateTime.Now.ToString("HHmmss") + ".xlsm";
            string basePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string fullPath = basePath + "\\reports\\" + savedFileName;
            workBook.SaveAs(fullPath);
            while (application.Visible) { }
            CloseExcel();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);
        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);
                application = null;
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }
    }

    class Director : User, iReport
    {
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;

        public Director()
        {

        }

        internal override string sendRules()
        {
            base.sendRules();
            string res = "director";
            return res;

        }

        public void Report(DataGridView info, User _user)
        {
            application = new Application
            {
                DisplayAlerts = false
            };
            const string template = "template.xlsm";
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));
            worksheet = workBook.ActiveSheet as Worksheet;
            int cellRowIndex = 1;
            int cellColumnIndex = 1;

            for (int i = 0; i < info.Rows.Count; i++)
            {
                for (int j = 0; j < info.Columns.Count; j++)
                {
                    if (cellRowIndex.Equals(1)) { worksheet.Cells[cellRowIndex, cellColumnIndex + 2] = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(); cellRowIndex++; cellColumnIndex = 0; }
                    else if (cellRowIndex.Equals(2)) { worksheet.Cells[cellRowIndex, cellColumnIndex] = "REPORT by Director: " + _user.username; cellRowIndex++; cellColumnIndex = 0; j -= 2; }
                    else if (cellRowIndex.Equals(3))
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Columns[j].HeaderText;
                        rng.Font.Color = XlRgbColor.rgbBlack;
                        rng.Interior.Color = XlRgbColor.rgbBlanchedAlmond;
                    }
                    else
                    {
                        Range rng = worksheet.Cells[cellRowIndex, cellColumnIndex];
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = info.Rows[i - 1].Cells[j].Value.ToString();
                        rng.Font.Color = XlRgbColor.rgbBlack;
                        rng.Interior.Color = XlRgbColor.rgbLightGray;
                        rng.Borders[XlBordersIndex.xlInsideVertical].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeLeft].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeRight].Weight = 2d;
                        rng.Borders[XlBordersIndex.xlEdgeBottom].Weight = 2d;

                    }
                    cellColumnIndex++;
                }
                cellColumnIndex = 1;
                cellRowIndex++;
            }
            application.Visible = true;
            string savedFileName = passGen() + DateTime.Now.ToString("HHmmss") + ".xlsm";
            string basePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string fullPath = basePath + "\\reports\\" + savedFileName;
            workBook.SaveAs(fullPath);
            while (application.Visible) { }
            CloseExcel();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);

        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);
                application = null;
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }
    }
}
