namespace BioTrek.Presentation.Dto
{
    // DTO used to expose EnrichedData over the API
    public record EnrichedDataDto(int Id, string DataType, string Content);
}
