using EmployeeTimeSheet.Models;
using EmployeeTimeSheet.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTimeSheet.Repositories.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        List<Person> data = new List<Person>()
        {
            new Person { Id = Guid.Parse("B2BAE6D9-9C24-9E5E-435C-D6071084D51C"), FirstName = "Veda", LastName = "Richmond", Email = "ligula@necluctus.edu", Company = "Quisque Ac Libero LLP", Age = 42 },
            new Person { Id = Guid.Parse("06EFA30C-FDA6-DE75-A169-473352351C49"), FirstName = "Demetria", LastName = "Andrews", Email = "feugiat.metus@penatibuset.org", Company = "Nulla Facilisi Foundation", Age = 31 },
            new Person { Id = Guid.Parse("00F118DE-F21A-4995-A7A6-9E36D20B8E34"), FirstName = "Byron", LastName = "Holmes", Email = "neque.Sed.eget@non.co.uk", Company = "Et Associates", Age = 63 },
            new Person { Id = Guid.Parse("D6080568-1677-C0D1-6ABF-86DB838926B0"), FirstName = "Alexander", LastName = "Cummings", Email = "egestas.ligula@ultricesDuisvolutpat.ca", Company = "Vel Institute", Age = 23 },
            new Person { Id = Guid.Parse("A37404D3-EE5A-2DAA-4BDC-C80127FF5317"), FirstName = "Melinda", LastName = "Miles", Email = "justo.nec.ante@nonummyFusce.ca", Company = "Eu Nibh Vulputate Company", Age = 64 },
            new Person { Id = Guid.Parse("7A9CCB02-27F3-E5F8-073A-D73F21E87461"), FirstName = "Dustin", LastName = "Beck", Email = "iaculis@afeugiat.edu", Company = "Nec Diam Incorporated", Age = 35 },
            new Person { Id = Guid.Parse("B1C6F583-0707-C5BB-CA04-E81FA564AA5E"), FirstName = "Ralph", LastName = "Maddox", Email = "ipsum@vulputatelacus.co.uk", Company = "Enim Corp.", Age = 22 },
            new Person { Id = Guid.Parse("FF1E9955-BC4B-61AB-9D65-12E9CADE8AAA"), FirstName = "Levi", LastName = "Zamora", Email = "lectus.a.sollicitudin@nuncQuisque.com", Company = "Sodales At Velit Corp.", Age = 57 },
            new Person { Id = Guid.Parse("14512CA4-B5AA-128D-1BE5-1B46E0EC026E"), FirstName = "Driscoll", LastName = "Estrada", Email = "Phasellus@Craspellentesque.org", Company = "Id Mollis Nec LLC", Age = 37 },
            new Person { Id = Guid.Parse("3BF54A62-023B-30E5-1BF7-505DDB07E0DA"), FirstName = "Hiram", LastName = "Mejia", Email = "lacus.Mauris@semper.ca", Company = "Donec Tincidunt Donec Industries", Age = 59 },
            new Person { Id = Guid.Parse("C38CD1E8-850A-0210-6A04-FCC609DEAB04"), FirstName = "Mason", LastName = "Jefferson", Email = "Integer.vitae.nibh@nibh.co.uk", Company = "Lectus Justo Ltd", Age = 65 },
            new Person { Id = Guid.Parse("69FC1922-D5FD-50A6-64F8-5CCE0D927FC7"), FirstName = "Nigel", LastName = "Rich", Email = "id@faucibusleoin.net", Company = "Tristique Ac Ltd", Age = 52 },
            new Person { Id = Guid.Parse("50D824D8-C251-B9CF-E19D-0B5F8C82C791"), FirstName = "Tarik", LastName = "Hughes", Email = "enim@ultricesDuisvolutpat.edu", Company = "Lacus Varius Et Associates", Age = 58 },
            new Person { Id = Guid.Parse("69F22ADE-B5CF-3686-712E-6F44CE8BE5E5"), FirstName = "Wallace", LastName = "Gross", Email = "Curabitur.ut.odio@anteMaecenasmi.co.uk", Company = "Rhoncus Id Corporation", Age = 29 },
            new Person { Id = Guid.Parse("4EECFBE6-F898-0E3F-9FF9-312878FB2101"), FirstName = "Arden", LastName = "Rivers", Email = "magna.nec.quam@lobortis.net", Company = "Vivamus Corporation", Age = 59 },
            new Person { Id = Guid.Parse("2BA32B7F-94CB-B11A-CFC2-EB1FB50FBD67"), FirstName = "Vincent", LastName = "Fox", Email = "faucibus.Morbi.vehicula@ipsumdolor.edu", Company = "Imperdiet Dictum Magna Foundation", Age = 54 },
            new Person { Id = Guid.Parse("55D7C836-7EBA-122D-69EB-906E63423A1E"), FirstName = "Aphrodite", LastName = "Randolph", Email = "ac@scelerisquesedsapien.org", Company = "Mattis Foundation", Age = 27 },
            new Person { Id = Guid.Parse("12A0E5AB-28B9-CABB-A66C-CB34EC22BCDB"), FirstName = "Alisa", LastName = "Riggs", Email = "montes@scelerisque.edu", Company = "Rutrum Non Hendrerit Consulting", Age = 25 },
            new Person { Id = Guid.Parse("5ED94E08-8D3D-8C81-029B-AF2598CDAC1A"), FirstName = "Jaime", LastName = "Lott", Email = "velit.Quisque.varius@aliquetmolestie.net", Company = "Ut LLC", Age = 61 },
            new Person { Id = Guid.Parse("4863226B-5FF5-90DC-68C6-FCCAEF57DF7A"), FirstName = "Jamalia", LastName = "Buchanan", Email = "arcu.eu.odio@congue.ca", Company = "Curabitur Sed Tortor Ltd", Age = 61 },
            new Person { Id = Guid.Parse("C9673E69-2C11-B2FA-070D-0022EAE3C4E0"), FirstName = "Raya", LastName = "Mckenzie", Email = "Integer.sem.elit@bibendumsedest.net", Company = "In Inc.", Age = 43 },
            new Person { Id = Guid.Parse("CDA88542-F99D-92F3-E92E-0FD77D5BB93C"), FirstName = "Dante", LastName = "Blackwell", Email = "Cras.eget.nisi@Vestibulum.edu", Company = "Nec Foundation", Age = 48 },
            new Person { Id = Guid.Parse("2AF24BEC-3A7A-E2C1-F346-6A3EF9EA9CA6"), FirstName = "Kato", LastName = "Dickson", Email = "facilisis@doloregestas.co.uk", Company = "Augue Scelerisque Institute", Age = 60 },
            new Person { Id = Guid.Parse("021F4756-7DE1-8225-CFF6-B734B53FA4C1"), FirstName = "Clio", LastName = "Shaffer", Email = "tincidunt@eget.edu", Company = "Dui Augue Eu Limited", Age = 29 },
            new Person { Id = Guid.Parse("332AAB7F-3E95-8F1E-6035-71B4094FA1E6"), FirstName = "Hamilton", LastName = "Kidd", Email = "magna@felisegetvarius.net", Company = "Enim Incorporated", Age = 26 },
            new Person { Id = Guid.Parse("D0C88A60-7F6F-0E07-E7C6-5730D00DD908"), FirstName = "Kerry", LastName = "Oneil", Email = "Suspendisse.eleifend@Crasdolor.com", Company = "Interdum Inc.", Age = 48 },
            new Person { Id = Guid.Parse("F05EBB79-3CFB-99AC-48ED-3886A0BCEF5C"), FirstName = "Mohammad", LastName = "Thompson", Email = "elit.pretium.et@malesuadafamesac.com", Company = "Facilisis Eget Ipsum Inc.", Age = 34 },
            new Person { Id = Guid.Parse("D6F0D845-63C3-EEFD-4166-DA2BB1E49328"), FirstName = "Vernon", LastName = "Cardenas", Email = "felis@conguea.org", Company = "Iaculis Quis Consulting", Age = 35 },
            new Person { Id = Guid.Parse("BFEA890C-0054-EA02-5D6D-0A6EA300E7CB"), FirstName = "Murphy", LastName = "Weaver", Email = "Proin@feugiatnecdiam.org", Company = "Integer Urna Institute", Age = 63 },
            new Person { Id = Guid.Parse("CC0632B6-305A-60A4-1093-8CA5B71ED87A"), FirstName = "Xena", LastName = "Hart", Email = "facilisis.facilisis.magna@loremutaliquam.net", Company = "Orci Industries", Age = 39 },
            new Person { Id = Guid.Parse("D8C562E8-B9FA-3B34-15E9-DF6A4B62C325"), FirstName = "Ivor", LastName = "Lara", Email = "Proin.ultrices.Duis@lacuspede.com", Company = "Ante Foundation", Age = 30 },
            new Person { Id = Guid.Parse("0BEF9C73-AD54-8922-A420-541E741EF746"), FirstName = "Dana", LastName = "Merritt", Email = "et.magnis@Sed.edu", Company = "Eget Industries", Age = 53 },
            new Person { Id = Guid.Parse("FC8DA262-E0D8-BC39-AEA4-73259984AD62"), FirstName = "Brielle", LastName = "Woodward", Email = "elit.Nulla@magna.edu", Company = "Lorem Vehicula Et Foundation", Age = 45 },
            new Person { Id = Guid.Parse("29BF39A3-4B40-AE2D-A4A7-E8216901AB88"), FirstName = "Hasad", LastName = "Duran", Email = "et@nislsem.co.uk", Company = "Magna Suspendisse Consulting", Age = 49 },
            new Person { Id = Guid.Parse("9A811FA3-FECE-C7C1-B412-ECF0061144CE"), FirstName = "Quamar", LastName = "Moses", Email = "Proin.sed.turpis@imperdiet.co.uk", Company = "Eros Institute", Age = 32 },
            new Person { Id = Guid.Parse("84D0C3D2-9278-43A9-1743-EFD0DEF63722"), FirstName = "Scarlet", LastName = "Barlow", Email = "nisl.sem.consequat@idnunc.co.uk", Company = "Aenean Massa Consulting", Age = 58 },
            new Person { Id = Guid.Parse("DC5282B4-D606-03A6-BC3A-C52359FB9A89"), FirstName = "Courtney", LastName = "Foley", Email = "urna@mauris.org", Company = "Mauris Associates", Age = 47 },
            new Person { Id = Guid.Parse("159CF385-4AFC-D044-00DF-FB67FDA36EA0"), FirstName = "Kennedy", LastName = "Shields", Email = "Cras@Nullam.org", Company = "Id Nunc Interdum LLC", Age = 40 },
            new Person { Id = Guid.Parse("F73B0AE1-3AD5-B65D-BAB9-2B2916C84EB5"), FirstName = "Eve", LastName = "Maynard", Email = "metus.sit@lorem.ca", Company = "Pellentesque Ultricies Associates", Age = 30 },
            new Person { Id = Guid.Parse("0D7021D8-B23A-A796-DEB1-B75CB1327FB4"), FirstName = "Debra", LastName = "Ellis", Email = "Nullam@pretium.ca", Company = "Nulla Tincidunt Industries", Age = 24 },
            new Person { Id = Guid.Parse("210DFA08-8020-25BE-C49E-5337AAEAB03E"), FirstName = "Vivian", LastName = "Mcguire", Email = "ornare@at.net", Company = "Id Consulting", Age = 48 },
            new Person { Id = Guid.Parse("8C79C508-367F-6FD6-9E37-2CEEF56B956C"), FirstName = "Jason", LastName = "Mckinney", Email = "tempor.augue@purusNullam.com", Company = "Netus Et Inc.", Age = 48 },
            new Person { Id = Guid.Parse("ED8EC1B2-3CC2-6514-D47A-AE82803D986C"), FirstName = "Patrick", LastName = "Small", Email = "fringilla@Proinsed.co.uk", Company = "Hendrerit Institute", Age = 61 },
            new Person { Id = Guid.Parse("C8873DF0-A93E-BB8E-8FE1-12FF015BA7C8"), FirstName = "Drew", LastName = "Travis", Email = "scelerisque.scelerisque@velit.org", Company = "Penatibus Corp.", Age = 55 },
            new Person { Id = Guid.Parse("5EE28F9C-624B-A0FA-5BC5-1D0967B40C59"), FirstName = "Burke", LastName = "Miller", Email = "Suspendisse@aliquet.net", Company = "Quis Diam Pellentesque PC", Age = 41 },
            new Person { Id = Guid.Parse("7564BDF1-7C57-78A1-BC0A-92AB3A2A6412"), FirstName = "Ralph", LastName = "Medina", Email = "Class.aptent.taciti@mauris.edu", Company = "Lorem Ipsum Dolor Corp.", Age = 55 },
            new Person { Id = Guid.Parse("BD785ACA-979D-A3E6-D54C-02FF9877D6F0"), FirstName = "Alana", LastName = "Madden", Email = "at.velit.Cras@aptenttacitisociosqu.net", Company = "Euismod Est Arcu Institute", Age = 33 },
            new Person { Id = Guid.Parse("F6EBEA99-E527-8F42-D6E3-35E2527D1E4B"), FirstName = "Salvador", LastName = "Cohen", Email = "magna.Duis@Phasellus.org", Company = "Purus PC", Age = 37 },
            new Person { Id = Guid.Parse("69C953F0-3406-00FF-2FFD-B21885F48EDA"), FirstName = "Jenette", LastName = "Dejesus", Email = "adipiscing.Mauris.molestie@liberoduinec.ca", Company = "Lectus Justo Incorporated", Age = 56 },
            new Person { Id = Guid.Parse("BE44C0FF-D7F7-FF1C-1482-C1FFF4AD16B8"), FirstName = "Ramona", LastName = "Gilliam", Email = "massa.Vestibulum@lectuspede.ca", Company = "Imperdiet Dictum LLP", Age = 24 },
        };


        public void Add(Person item)
        {
            data.Add(item);
        }


        public Person GetItem(Guid id)
        {
            return data.FirstOrDefault(x => x.Id == id);
        }


        public IEnumerable<Person> GetItems(int firstIndex, int itemsCount)
        {
            List<Person> resultList = new List<Person>();
            for (int i = 0; i < itemsCount; i++)
            {
                resultList.Add(data[firstIndex + i]);
            }
            return resultList;
        }


        public void Update(Guid id)
        {
            var itemToUpdate = data.Select(x => x.Id == id);
        }


        public void Delete(Guid id)
        {
            Person removedItem = data.Single(x => x.Id == id);
            if (removedItem != null)
            {
                data.Remove(removedItem);
            }
        }

        public Person SearchByName(string name)
        {
            return data.FirstOrDefault(x => x.fu == item);
        }
    }
}
