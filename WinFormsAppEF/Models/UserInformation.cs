
namespace WinFormsAppEF.Models;

public partial class UserInformation
{
    public int Uid { get; set; }

    public string? UserFirstName { get; set; }

    public string? UserLastName { get; set; }

    public string? UserMiddleName { get; set; }

    public string Email { get; set; } = null!;

    public string? Company { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string City { get; set; } = null!;

    public string StateProvinceId { get; set; } = null!;

    public string ZipPostalCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string Password { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifyDate { get; set; }

    public string? ModifiedBy { get; set; }

    public byte[] RowStamp { get; set; } = null!;
}
