using GbyG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GbyG.Controllers
{
    [EnableCors(origins: "http://localhost:45478", headers: "*", methods: "*")]
    public class SamplesController : ApiController
    {
        public IList<Sample> Samples = new List<Sample>
        {
            new Sample() {SampleId = 1,Barcode = "129076",CreatedAt = DateTime.Parse("01/02/15"),CreatedBy = 6,StatusId = 3},
            new Sample() {SampleId = 2,Barcode = "850314",CreatedAt = DateTime.Parse("06/15/15"),CreatedBy = 7,StatusId = 3},
            new Sample() {SampleId = 3,Barcode = "176033",CreatedAt = DateTime.Parse("07/31/15"),CreatedBy = 7,StatusId = 0},
            new Sample() {SampleId = 4,Barcode = "129629",CreatedAt = DateTime.Parse("01/21/15"),CreatedBy = 3,StatusId = 0},
            new Sample() {SampleId = 5,Barcode = "773561",CreatedAt = DateTime.Parse("02/21/15"),CreatedBy = 9,StatusId = 1},
            new Sample() {SampleId = 6,Barcode = "255253",CreatedAt = DateTime.Parse("05/13/15"),CreatedBy = 9,StatusId = 0},
            new Sample() {SampleId = 7,Barcode = "693294",CreatedAt = DateTime.Parse("05/11/15"),CreatedBy = 3,StatusId = 2},
            new Sample() {SampleId = 8,Barcode = "455116",CreatedAt = DateTime.Parse("09/13/15"),CreatedBy = 6,StatusId = 0},
            new Sample() {SampleId = 9,Barcode = "280561",CreatedAt = DateTime.Parse("04/08/15"),CreatedBy = 5,StatusId = 3},
            new Sample() {SampleId = 10,Barcode = "863760",CreatedAt =DateTime.Parse("01/25/16"),CreatedBy = 0,StatusId = 3},
            new Sample() {SampleId = 11,Barcode = "211102",CreatedAt =DateTime.Parse("08/24/15"),CreatedBy = 4,StatusId = 2},
            new Sample() {SampleId = 12,Barcode = "193882",CreatedAt =DateTime.Parse("01/23/16"),CreatedBy = 8,StatusId = 1},
            new Sample() {SampleId = 13,Barcode = "502533",CreatedAt =DateTime.Parse("03/08/16"),CreatedBy = 2,StatusId = 1},
            new Sample() {SampleId = 14,Barcode = "371726",CreatedAt =DateTime.Parse("04/15/15"),CreatedBy = 8,StatusId = 1},
            new Sample() {SampleId = 15,Barcode = "807891",CreatedAt =DateTime.Parse("05/17/15"),CreatedBy = 2,StatusId = 1},
            new Sample() {SampleId = 16,Barcode = "845318",CreatedAt =DateTime.Parse("03/22/16"),CreatedBy = 7,StatusId = 1},
            new Sample() {SampleId = 17,Barcode = "601386",CreatedAt =DateTime.Parse("11/18/15"),CreatedBy = 3,StatusId = 1},
            new Sample() {SampleId = 18,Barcode = "978804",CreatedAt =DateTime.Parse("05/31/15"),CreatedBy = 5,StatusId = 2},
            new Sample() {SampleId = 19,Barcode = "759456",CreatedAt =DateTime.Parse("09/23/15"),CreatedBy = 8,StatusId = 2},
            new Sample() {SampleId = 20,Barcode = "949933",CreatedAt =DateTime.Parse("07/04/15"),CreatedBy = 0,StatusId = 3},
            new Sample() {SampleId = 21,Barcode = "411443",CreatedAt =DateTime.Parse("03/16/15"),CreatedBy = 3,StatusId = 0},
            new Sample() {SampleId = 22,Barcode = "202485",CreatedAt =DateTime.Parse("09/03/15"),CreatedBy = 0,StatusId = 3},
            new Sample() {SampleId = 23,Barcode = "737715",CreatedAt =DateTime.Parse("10/07/15"),CreatedBy = 0,StatusId = 1},
            new Sample() {SampleId = 24,Barcode = "106957",CreatedAt =DateTime.Parse("10/03/15"),CreatedBy = 7,StatusId = 1},
            new Sample() {SampleId = 25,Barcode = "561154",CreatedAt =DateTime.Parse("02/23/16"),CreatedBy = 9,StatusId = 1},
            new Sample() {SampleId = 26,Barcode = "923720",CreatedAt =DateTime.Parse("06/09/15"),CreatedBy = 2,StatusId = 1},
            new Sample() {SampleId = 27,Barcode = "985114",CreatedAt =DateTime.Parse("04/17/15"),CreatedBy = 4,StatusId = 0},
            new Sample() {SampleId = 28,Barcode = "544078",CreatedAt =DateTime.Parse("06/16/15"),CreatedBy = 6,StatusId = 3},
            new Sample() {SampleId = 29,Barcode = "605315",CreatedAt =DateTime.Parse("06/23/15"),CreatedBy = 7,StatusId = 0},
            new Sample() {SampleId = 30,Barcode = "588963",CreatedAt =DateTime.Parse("02/13/15"),CreatedBy = 7,StatusId = 1},
            new Sample() {SampleId = 31,Barcode = "646434",CreatedAt =DateTime.Parse("08/23/15"),CreatedBy = 0,StatusId = 2},
            new Sample() {SampleId = 32,Barcode = "819931",CreatedAt =DateTime.Parse("11/10/15"),CreatedBy = 0,StatusId = 2},
            new Sample() {SampleId = 33,Barcode = "978799",CreatedAt =DateTime.Parse("11/06/15"),CreatedBy = 2,StatusId = 3},
            new Sample() {SampleId = 34,Barcode = "250878",CreatedAt =DateTime.Parse("03/14/16"),CreatedBy = 6,StatusId = 1},
            new Sample() {SampleId = 35,Barcode = "499463",CreatedAt =DateTime.Parse("10/20/15"),CreatedBy = 5,StatusId = 3},
            new Sample() {SampleId = 36,Barcode = "261808",CreatedAt =DateTime.Parse("09/25/15"),CreatedBy = 5,StatusId = 3},
            new Sample() {SampleId = 37,Barcode = "496077",CreatedAt =DateTime.Parse("04/12/15"),CreatedBy = 8,StatusId = 2},
            new Sample() {SampleId = 38,Barcode = "939988",CreatedAt =DateTime.Parse("05/15/15"),CreatedBy = 4,StatusId = 2},
            new Sample() {SampleId = 39,Barcode = "142598",CreatedAt =DateTime.Parse("06/04/15"),CreatedBy = 7,StatusId = 1},
            new Sample() {SampleId = 40,Barcode = "648235",CreatedAt =DateTime.Parse("12/26/15"),CreatedBy = 6,StatusId = 2},
            new Sample() {SampleId = 41,Barcode = "949270",CreatedAt =DateTime.Parse("10/22/15"),CreatedBy = 0,StatusId = 0},
            new Sample() {SampleId = 42,Barcode = "606179",CreatedAt =DateTime.Parse("10/12/15"),CreatedBy = 5,StatusId = 2},
            new Sample() {SampleId = 43,Barcode = "762654",CreatedAt =DateTime.Parse("03/04/16"),CreatedBy = 2,StatusId = 0},
            new Sample() {SampleId = 44,Barcode = "230403",CreatedAt =DateTime.Parse("07/20/15"),CreatedBy = 5,StatusId = 1},
            new Sample() {SampleId = 45,Barcode = "419103",CreatedAt =DateTime.Parse("02/09/16"),CreatedBy = 2,StatusId = 0},
            new Sample() {SampleId = 46,Barcode = "105914",CreatedAt =DateTime.Parse("01/19/16"),CreatedBy = 5,StatusId = 3},
            new Sample() {SampleId = 47,Barcode = "292591",CreatedAt =DateTime.Parse("04/04/16"),CreatedBy = 0,StatusId = 2},
            new Sample() {SampleId = 48,Barcode = "460439",CreatedAt =DateTime.Parse("03/25/16"),CreatedBy = 2,StatusId = 3},
            new Sample() {SampleId = 49,Barcode = "905492",CreatedAt =DateTime.Parse("02/13/15"),CreatedBy = 4,StatusId = 0},
            new Sample() {SampleId = 50,Barcode = "454128",CreatedAt =DateTime.Parse("09/20/15"),CreatedBy = 2,StatusId = 1},
            new Sample() {SampleId = 51,Barcode = "245743",CreatedAt =DateTime.Parse("04/17/15"),CreatedBy = 2,StatusId = 0},
            new Sample() {SampleId = 52,Barcode = "127239",CreatedAt =DateTime.Parse("09/24/15"),CreatedBy = 3,StatusId = 3},
            new Sample() {SampleId = 53,Barcode = "747765",CreatedAt =DateTime.Parse("10/16/15"),CreatedBy = 5,StatusId = 0},
            new Sample() {SampleId = 54,Barcode = "141601",CreatedAt =DateTime.Parse("03/31/15"),CreatedBy = 2,StatusId = 1},
            new Sample() {SampleId = 55,Barcode = "427192",CreatedAt =DateTime.Parse("03/01/15"),CreatedBy = 3,StatusId = 3},
            new Sample() {SampleId = 56,Barcode = "779537",CreatedAt =DateTime.Parse("04/25/15"),CreatedBy = 3,StatusId = 0},
            new Sample() {SampleId = 57,Barcode = "614487",CreatedAt =DateTime.Parse("12/04/15"),CreatedBy = 8,StatusId = 3},
            new Sample() {SampleId = 58,Barcode = "771285",CreatedAt =DateTime.Parse("12/24/15"),CreatedBy = 7,StatusId = 3},
            new Sample() {SampleId = 59,Barcode = "868108",CreatedAt =DateTime.Parse("01/21/16"),CreatedBy = 5,StatusId = 3},
            new Sample() {SampleId = 60,Barcode = "586986",CreatedAt =DateTime.Parse("11/07/15"),CreatedBy = 1,StatusId = 3},
            new Sample() {SampleId = 61,Barcode = "957210",CreatedAt =DateTime.Parse("01/28/15"),CreatedBy = 0,StatusId = 3},
            new Sample() {SampleId = 62,Barcode = "925265",CreatedAt =DateTime.Parse("02/09/16"),CreatedBy = 6,StatusId = 2},
            new Sample() {SampleId = 63,Barcode = "229746",CreatedAt =DateTime.Parse("08/02/15"),CreatedBy = 1,StatusId = 2},
            new Sample() {SampleId = 64,Barcode = "329580",CreatedAt =DateTime.Parse("05/07/15"),CreatedBy = 4,StatusId = 0},
            new Sample() {SampleId = 65,Barcode = "398802",CreatedAt =DateTime.Parse("11/18/15"),CreatedBy = 3,StatusId = 1},
            new Sample() {SampleId = 66,Barcode = "793846",CreatedAt =DateTime.Parse("04/04/16"),CreatedBy = 7,StatusId = 3},
            new Sample() {SampleId = 67,Barcode = "194543",CreatedAt =DateTime.Parse("01/16/15"),CreatedBy = 0,StatusId = 2},
            new Sample() {SampleId = 68,Barcode = "699892",CreatedAt =DateTime.Parse("03/06/16"),CreatedBy = 5,StatusId = 2},
            new Sample() {SampleId = 69,Barcode = "849262",CreatedAt =DateTime.Parse("11/20/15"),CreatedBy = 5,StatusId = 0},
            new Sample() {SampleId = 70,Barcode = "212969",CreatedAt =DateTime.Parse("02/23/16"),CreatedBy = 1,StatusId = 2},
            new Sample() {SampleId = 71,Barcode = "913224",CreatedAt =DateTime.Parse("08/17/15"),CreatedBy = 6,StatusId = 3},
            new Sample() {SampleId = 72,Barcode = "283784",CreatedAt =DateTime.Parse("01/23/15"),CreatedBy = 1,StatusId = 3},
            new Sample() {SampleId = 73,Barcode = "964445",CreatedAt =DateTime.Parse("03/07/15"),CreatedBy = 1,StatusId = 1},
            new Sample() {SampleId = 74,Barcode = "219254",CreatedAt =DateTime.Parse("06/11/15"),CreatedBy = 7,StatusId = 2},
            new Sample() {SampleId = 75,Barcode = "136235",CreatedAt =DateTime.Parse("03/21/15"),CreatedBy = 4,StatusId = 3},
            new Sample() {SampleId = 76,Barcode = "371430",CreatedAt =DateTime.Parse("03/19/15"),CreatedBy = 2,StatusId = 2},
            new Sample() {SampleId = 77,Barcode = "219597",CreatedAt =DateTime.Parse("12/12/15"),CreatedBy = 3,StatusId = 3},
            new Sample() {SampleId = 78,Barcode = "721655",CreatedAt =DateTime.Parse("04/29/16"),CreatedBy = 5,StatusId = 2},
            new Sample() {SampleId = 79,Barcode = "434154",CreatedAt =DateTime.Parse("02/25/16"),CreatedBy = 8,StatusId = 0},
            new Sample() {SampleId = 80,Barcode = "290254",CreatedAt =DateTime.Parse("11/02/15"),CreatedBy = 9,StatusId = 2},
            new Sample() {SampleId = 81,Barcode = "736586",CreatedAt =DateTime.Parse("05/30/15"),CreatedBy = 4,StatusId = 2},
            new Sample() {SampleId = 82,Barcode = "622526",CreatedAt =DateTime.Parse("11/08/15"),CreatedBy = 0,StatusId = 1},
            new Sample() {SampleId = 83,Barcode = "693936",CreatedAt =DateTime.Parse("03/21/16"),CreatedBy = 1,StatusId = 0},
            new Sample() {SampleId = 84,Barcode = "529728",CreatedAt =DateTime.Parse("02/25/15"),CreatedBy = 1,StatusId = 2},
            new Sample() {SampleId = 85,Barcode = "963244",CreatedAt =DateTime.Parse("11/22/15"),CreatedBy = 9,StatusId = 0},
            new Sample() {SampleId = 86,Barcode = "261164",CreatedAt =DateTime.Parse("06/26/15"),CreatedBy = 9,StatusId = 2},
            new Sample() {SampleId = 87,Barcode = "986536",CreatedAt =DateTime.Parse("01/07/16"),CreatedBy = 6,StatusId = 1},
            new Sample() {SampleId = 88,Barcode = "572741",CreatedAt =DateTime.Parse("12/01/15"),CreatedBy = 6,StatusId = 1},
            new Sample() {SampleId = 89,Barcode = "125921",CreatedAt =DateTime.Parse("08/03/15"),CreatedBy = 2,StatusId = 2},
            new Sample() {SampleId = 90,Barcode = "262858",CreatedAt =DateTime.Parse("12/07/15"),CreatedBy = 3,StatusId = 0},
            new Sample() {SampleId = 91,Barcode = "879489",CreatedAt =DateTime.Parse("09/02/15"),CreatedBy = 7,StatusId = 1},
            new Sample() {SampleId = 92,Barcode = "105797",CreatedAt =DateTime.Parse("12/26/15"),CreatedBy = 6,StatusId = 1},
            new Sample() {SampleId = 93,Barcode = "806498",CreatedAt =DateTime.Parse("07/26/15"),CreatedBy = 8,StatusId = 3},
            new Sample() {SampleId = 94,Barcode = "960686",CreatedAt =DateTime.Parse("04/07/16"),CreatedBy = 2,StatusId = 2},
            new Sample() {SampleId = 95,Barcode = "201332",CreatedAt =DateTime.Parse("09/19/15"),CreatedBy = 4,StatusId = 0},
            new Sample() {SampleId = 96,Barcode = "405572",CreatedAt =DateTime.Parse("11/04/15"),CreatedBy = 3,StatusId = 0},
            new Sample() {SampleId = 97,Barcode = "204617",CreatedAt =DateTime.Parse("09/05/15"),CreatedBy = 5,StatusId = 1},
            new Sample() {SampleId = 98,Barcode = "767548",CreatedAt =DateTime.Parse("02/09/16"),CreatedBy = 7,StatusId = 2},
            new Sample() {SampleId = 99,Barcode = "363492",CreatedAt =DateTime.Parse("12/18/15"),CreatedBy = 6,StatusId = 1}
        };

        public IList<Status> Statuses = new List<Status>
        {
            new Status() {StatusId = 0, StatusType = "Received"},
            new Status() {StatusId = 1, StatusType = "Accessioning"},
            new Status() {StatusId = 2, StatusType = "In Lab"},
            new Status() {StatusId = 3, StatusType = "Report Generation"},
        };

        public IList<User> Users = new List<User>
        {
            new User() {FirstName = "Kristine",LastName = "Butler",UserId = 0},
            new User() {FirstName = "Alfred",LastName = "McKenzie",UserId = 1},
            new User() {FirstName = "Cora",LastName = "Hunt",UserId = 2},
            new User() {FirstName = "Brad",LastName = "Huff",UserId = 3},
            new User() {FirstName = "Dewey",LastName = "McDonald",UserId = 4},
            new User() {FirstName = "Orlando",LastName = "Holt",UserId = 5},
            new User() {FirstName = "Clint",LastName = "Reid",UserId = 6},
            new User() {FirstName = "Kim",LastName = "Mullins",UserId = 7},
            new User() {FirstName = "Blanche",LastName = "Mack",UserId = 8},
            new User() {FirstName = "Dwayne",LastName = "Pena",UserId = 9}
        };

        // /api/Samples/GetSamplesByStatus?statustype=Received
        public IHttpActionResult GetSamplesByStatus(string statustype)
        {
            var result = from sample in Samples
                         join status in Statuses
                             on sample.StatusId equals status.StatusId
                         where status.StatusType == statustype
                         select sample;

            return Json(result);
        }

        // /api/Samples/GetAllSamplesByStatusUser
        public IHttpActionResult GetAllSamplesByStatusUser()
        {
            var result
            = from sample in Samples
              join status in Statuses
                      on sample.StatusId equals status.StatusId
              join user in Users
                      on sample.CreatedBy equals user.UserId

              select new SamplesByStatusUser()
              {
                  FirstName = user.FirstName,
                  LastName = user.LastName,
                  Sample = new Sample()
                  {
                      Barcode = sample.Barcode,
                      CreatedAt = sample.CreatedAt,
                      CreatedBy = sample.CreatedBy,
                      SampleId = sample.SampleId,
                      StatusId = sample.StatusId
                  },
                  Status = status.StatusType
              };

            return Json(result);
        }

        // /api/Samples/GetSamplesByUserMatch
        public IHttpActionResult GetSamplesByUserMatch(int createdBy)
        {
            var result = from sample in Samples
                         join user in Users
                             on sample.CreatedBy equals user.UserId
                         where user.UserId == createdBy
                         //where user.LastName.ToUpper().Contains(name.ToUpper()) || user.FirstName.ToUpper().Contains(name.ToUpper())
                         select new Sample()
                         {
                             Barcode = sample.Barcode,
                             CreatedAt = sample.CreatedAt,
                             CreatedBy = sample.CreatedBy,
                             SampleId = sample.SampleId
                         };

            return Json(result);
        }

        // PUT api/Samples
        public IHttpActionResult Put([FromBody]Sample inputSample)
        {
            var isValidStatusId = Statuses.Any(s => s.StatusId == inputSample.StatusId);
            var isValidUserId = Users.Any(u => u.UserId == inputSample.CreatedBy);

            if (!isValidStatusId || !isValidUserId) return NotFound();

            Samples.Add(new Sample()
            {
                Barcode = inputSample.Barcode,
                CreatedAt = inputSample.CreatedAt,
                CreatedBy = inputSample.CreatedBy,
                SampleId = inputSample.SampleId,
                StatusId = inputSample.StatusId
            });

            return Ok();
        }
    }
}