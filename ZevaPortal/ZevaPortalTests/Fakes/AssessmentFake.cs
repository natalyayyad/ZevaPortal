using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortalTests.Fakes
{
    class AssessmentFake : IAssessmentsController
    {
        private readonly ZevaPortalDbContext _context;
        private readonly List<Assessment> _Assessments;

        public AssessmentFake()
        {
            _Assessments = new List<Assessment>()
            {
                new Assessment() { AssessmentId = Guid.NewGuid().GetHashCode(),
                    Date = new DateTime(2015, 12, 08), FormId =  1, Form = new Form(), Id = new Guid ("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200")},
                new Assessment { AssessmentId = Guid.NewGuid().GetHashCode(),
                    Date = new DateTime(2016, 4, 13), FormId =  2, Form = new Form(), Id = new Guid ("815accac-fd5b-478a-a9d6-f171a2f6ae7f")},
                new Assessment { AssessmentId = Guid.NewGuid().GetHashCode(),
                    Date = new DateTime(2017, 7, 3), FormId =  3, Form = new Form(), Id = new Guid ("33704c4a-5b87-464c-bfb6-51971b4d18ad")}
            };

        }

        public void DeleteAssessment(int id)
        {
            var existing = _Assessments.First(a => a.AssessmentId == id);
            _Assessments.Remove(existing);
        }

        public IEnumerable<Assessment> GetAsessments()
        {
            return _Assessments;
        }

        public Assessment GetAssessment(int id)
        {
            return _Assessments.Where(a => a.AssessmentId == id)
            .FirstOrDefault();
        }

        public Assessment PostAssessment(Assessment assessment)
        {
            assessment.AssessmentId = Guid.NewGuid().GetHashCode();
            _Assessments.Add(assessment);
            return assessment;
        }

        // Update what exactly? 
        public Task<IActionResult> PutAssessment(int id, Assessment assessment)
        {
            throw new NotImplementedException();
        }
    }
}
