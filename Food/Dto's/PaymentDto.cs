namespace Food.Dto_s
{
    public class PaymentDto
    {
        public int CardNumber { get; set; }
        public string Type { get; set; } = string.Empty;

        public string Cvv { get; set; } = string.Empty;
        public string TableNumber { get; set; } = string.Empty;

    }
}
