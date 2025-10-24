using BioTrek.Domain;
using BioTrek.Presentation.Dto;

namespace BioTrek.Application.Mappers
{
    public static class EnrichedDataMapper
    {
        public static EnrichedDataDto ToDto(this EnrichedData e) =>
            new EnrichedDataDto(e.Id, e.DataType, e.Content);

        public static EnrichedData ToDomain(this EnrichedDataDto dto) =>
            new EnrichedData
            {
                Id = dto.Id,
                DataType = dto.DataType,
                Content = dto.Content
            };
    }
}
