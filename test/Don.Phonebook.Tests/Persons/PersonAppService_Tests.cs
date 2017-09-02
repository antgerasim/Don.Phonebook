using System;
using System.Collections.Generic;
using System.Text;
using Abp.TestBase;
using Don.Phonebook.Persons;
using Don.Phonebook.Persons.Dto;
using Shouldly;
using Xunit;

namespace Don.Phonebook.Tests.Persons
{
   public class PersonAppService_Tests: PhonebookTestBase
    {

        private readonly IPersonAppService _personAppService;
      

        public PersonAppService_Tests()
        {
            _personAppService = Resolve<IPersonAppService>();
        }

        [Fact]
        public void Should_Get_All_People_Without_Any_Filter()
        {
            //Act
            var persons = _personAppService.GetPeople(new GetPeopleInput());

            //Assert
            persons.Items.Count.ShouldBe(2);
        }

        [Fact]
        public void Should_Get_People_With_Filter()
        {
            //Act 
            var persons = _personAppService.GetPeople(new GetPeopleInput()
            {
                Filter = "adams"
            });

            //Assert
            persons.Items.Count.ShouldBe(1);
            persons.Items[0].Name.ShouldBe("Douglas");
            persons.Items[0].Surname.ShouldBe("Adams");

        }


    }
}
