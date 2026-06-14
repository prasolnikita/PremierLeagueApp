using PremierLeagueApp.Domain.SharedKernel;

namespace PremierLeagueApp.Domain.Features.Stadiums
{
    public class Stadium : BaseEntity<StadiumId>, IAggregateRoot
    {
        public string Name { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public int Capacity { get; private set; }
        public int BuiltYear { get; private set; }
        public int PitchLength { get; private set; }
        public int PitchWidth { get; private set; }
        public bool IsDeleted { get; private set; }

        private Stadium() { }

        public static Stadium Create(string name, string city, int capacity, int builtYear, int pitchLength, int pitchWidth)
        {
            return new Stadium
            {
                Id = StadiumId.New(),
                Name = name,
                City = city,
                Capacity = capacity,
                BuiltYear = builtYear,
                PitchLength = pitchLength,
                PitchWidth = pitchWidth,
                IsDeleted = false
            };
        }

        public void Update(string name, string city, int capacity, int builtYear, int pitchLength, int pitchWidth)
        {
            Name = name;
            City = city;
            Capacity = capacity;
            BuiltYear = builtYear;
            PitchLength = pitchLength;
            PitchWidth = pitchWidth;
        }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
