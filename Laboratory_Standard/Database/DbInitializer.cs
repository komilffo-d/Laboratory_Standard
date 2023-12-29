using Lab_9.Database.Entities;
using Laboratory_Standard.Database.Entities;
using Laboratory_Standard.Database.Enum;

namespace Laboratory_Standard
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public DbInitializer Seed()
        {

            _modelBuilder.Entity<ExpertDb>().HasData(new ExpertDb[]
{
                            new ExpertDb{
                                Id=1,
                                LastName="Шишкова",
                                FirstName="Елена",
                                MiddleName="Владимировна",
                                RegisterNumber="00818",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                            new ExpertDb{
                                Id=2,
                                LastName="Тарасенко",
                                FirstName="Мария",
                                MiddleName="Владимировна",
                                RegisterNumber="00769",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                             new ExpertDb{
                                Id=3,
                                LastName="Давыдов",
                                FirstName="Сергей",
                                MiddleName="Юрьевич",
                                RegisterNumber="00778",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                             new ExpertDb{
                                Id=4,
                                LastName="Пелагейкина",
                                FirstName="Яра",
                                MiddleName="Григорьевна",
                                RegisterNumber="00803",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                            new ExpertDb{
                                Id=5,
                                LastName="Лепенькина",
                                FirstName="Эльвира",
                                MiddleName="Станиславовна",
                                RegisterNumber="00555",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                             new ExpertDb{
                                Id=6,
                                LastName="Макаренко",
                                FirstName="Оксана",
                                MiddleName="Валентиновна",
                                RegisterNumber="00814",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                             new ExpertDb{
                                Id=7,
                                LastName="Соловьева",
                                FirstName="Людьмила",
                                MiddleName="Фёдоровна",
                                RegisterNumber="00193",
                                TypeOrganisation=TypeOrganisation.Main

                            },
                             new ExpertDb{
                                Id=8,
                                LastName="Введенский",
                                FirstName="Константин",
                                MiddleName="Юрьевич",
                                RegisterNumber="00862",
                                TypeOrganisation=TypeOrganisation.Main

                            },
});

            return this;
        }
    }
}
