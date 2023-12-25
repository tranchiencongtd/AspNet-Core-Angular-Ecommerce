using Volo.Abp.Application.Dtos;

namespace Ecommerce.Admin;

public class BaseListFilterDto : PagedResultRequestDto
{
    public string Keyword { get; set; }
}