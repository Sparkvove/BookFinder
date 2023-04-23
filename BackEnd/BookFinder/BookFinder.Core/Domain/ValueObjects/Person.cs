using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFinder.Core.Domain.ValueObjects
{
    public class Person
    {
        public Guid Id { get; set; }

        public string FullName { get; private set; } = null!;

        private string? Surname { get; set; }
        private string? Name { get; set; }

        private string? Alias { get; set; }

        private int EmptyCount { get; set; } = 0;

        protected Person()
        {

        }
        protected Person(Guid id, string? surname, string? name, string? alias)
        {
            Id = id;
            SetSurname(surname);
            SetName(name);
            SetAlias(alias);
            if (this.EmptyCount == 3)
            {
                throw new Exception("Person need atleast Surname or Alias");
            }
            SetFullName();
        }

        private void SetName(string? name)
        {
            if(name is null || String.IsNullOrWhiteSpace(name))
            {
                this.EmptyCount++;
                return;
            }

            this.Name = name.ToLowerInvariant().Trim();
        }

        private void SetSurname(string? surname)
        {
            if (surname is null || String.IsNullOrWhiteSpace(surname))
            {
                this.EmptyCount++;
                return;
            }

            this.Surname = surname.ToLowerInvariant().Trim();
        }

        private void SetAlias(string? alias)
        {
            if(alias is null || String.IsNullOrWhiteSpace(alias))
            {
                this.EmptyCount++;
                return;
            }

            this.Alias = alias.ToLowerInvariant().Trim();
        }

        private void SetFullName()
        {
            var fullname = "";
            if(this.Name is not null || !String.IsNullOrWhiteSpace(this.Name))
            {
                fullname += this.Name + " ";
            }

            if (this.Alias is not null || !String.IsNullOrWhiteSpace(this.Alias))
            {
                fullname += "\"" + this.Alias + "\" ";
            }

            if(this.Surname is not null || !String.IsNullOrWhiteSpace(this.Alias))
            {
                fullname += this.Surname;
            }

            this.FullName = fullname;

        }

        public static Person CreatePersonWithOnlyAlias(Guid id, string alias)
            => new Person(id, null, null, alias);

        public static Person CreatePerson(Guid id, string surname, string? name, string? alias)
            => new Person(id, surname, name, alias);
    }
}
