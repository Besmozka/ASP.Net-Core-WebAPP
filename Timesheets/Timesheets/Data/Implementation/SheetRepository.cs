using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class SheetRepository : ISheetRepository
    {
        private static List<Sheet> _Sheets { get; set; } = new List<Sheet>
        {
            new Sheet
            {
                Id = Guid.Parse("CF075377-0CFE-0B88-3017-3BD7254AA60F"),
                EmployeeId = Guid.Parse("C425DAC4-881C-3E30-BCEA-C760FF0D69C3"),
                ContractId = Guid.Parse("9E98323B-5059-6EFF-035C-D61C0BD78E2A"),
                ServiceId = Guid.Parse("028A7513-9EA9-AFA7-1760-C4F4E2C13EED"),
                Amount = 8
            },
            new Sheet
            {
                Id = Guid.Parse("121B9F94-F062-FE3E-2FC8-632BB684E8A4"),
                EmployeeId = Guid.Parse("F2C78E95-43F9-7048-08F2-1222C7200372"),
                ContractId = Guid.Parse("4DCB3D5B-AC66-789B-55A3-D6EB5F3D15CA"),
                ServiceId = Guid.Parse("0AB1904A-B9ED-1A4C-0240-E36A4EC7539D"),
                Amount = 9
            },
            //new Sheet { Id = Guid.Parse("0E66A753-B48C-9303-5E42-4C914D2F0038", Date = "2022-02-08T04:41:05-08:00", EmployeeId = "6DA29B1A-AECD-B3F5-DA03-02F51757C76B", ContractId = "A2B3A4B7-7457-E062-384C-63855BF9E0C4", ServiceId = "C9C72BB3-D51D-0D22-774D-AFF3531CC496", Amount = 6 },
            //new Sheet { Id = Guid.Parse("2D0280D1-FAFD-0DEA-0AF6-4EC0EE244558", Date = "2022-01-26T10:31:48-08:00", EmployeeId = "D66A077C-2C5D-7201-C94F-402689C0FEFF", ContractId = "C9AD59B1-001A-5C2E-A54F-A13F9C06C50C", ServiceId = "520BEF7A-D68E-6CDD-1892-0980C873B6E6", Amount = 10 },
            //new Sheet { Id = Guid.Parse("1B4372D6-A56A-CE23-18A5-118E3F3ADF3E", Date = "2021-01-08T15:03:01-08:00", EmployeeId = "27319064-0CE9-39C7-9CFC-259853ECED23", ContractId = "CED42066-219B-B112-F7AB-F16A81E32019", ServiceId = "F9ECE389-9DF0-A89E-D9F8-65326C8F3A4D", Amount = 9 },
            //new Sheet { Id = Guid.Parse("00E4E273-2E9B-75F8-0560-3997504ACC53", Date = "2020-10-04T16:09:32-07:00", EmployeeId = "8E936777-F869-DC55-B072-E4AF3408761C", ContractId = "DBC40CA0-EF6B-FFA8-5371-996CBE0EAA12", ServiceId = "587EFE10-5EA9-B104-0863-47C8ED5BEA78", Amount = 1 },
            //new Sheet { Id = Guid.Parse("87498040-F63E-777E-F719-B40E86AD1FF4", Date = "2021-02-08T13:19:32-08:00", EmployeeId = "588779A1-913F-2C85-EA02-A916259B61DD", ContractId = "4A85CACB-4186-7DAC-A228-D277E49B088D", ServiceId = "FB8FC76B-425E-3471-4A19-ED75CC62773F", Amount = 10 },
            //new Sheet { Id = Guid.Parse("96C44776-1102-A208-074A-AE8F7C1A0860", Date = "2021-09-14T08:53:20-07:00", EmployeeId = "D09D00DF-CEF9-84E1-F286-F1F269E42997", ContractId = "4A3C6C6E-045C-AC17-BF58-631BF5D4E2A4", ServiceId = "DC7D73BA-79E9-2228-02E2-AF18869B799B", Amount = 1 },
            //new Sheet { Id = Guid.Parse("E107284A-9F88-866C-53BA-0387DE45B299", Date = "2022-02-15T13:35:54-08:00", EmployeeId = "F042DF58-4815-8138-64CD-6113522A1BEE", ContractId = "2A8815AE-C23A-6F6B-297C-C3C494D2907F", ServiceId = "C8220E99-56F2-15B3-22BA-64AC473AFF96", Amount = 9 },
            //new Sheet { Id = Guid.Parse("6FEB2968-CB10-6E36-B80C-FE1D46DA3981", Date = "2021-03-18T06:49:25-07:00", EmployeeId = "DDB47C7C-8A79-2FF6-BDF9-647E557E352B", ContractId = "B1073028-906A-674E-6472-12AE5316D428", ServiceId = "BAE5215B-23B0-B60C-D0DD-D30A549F6E0D", Amount = 7 },
        };

        public void Add(Sheet item)
        {
            _Sheets.Add(item);
        }

        public Sheet GetItem(Guid id)
        {
            return _Sheets.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Sheet> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
