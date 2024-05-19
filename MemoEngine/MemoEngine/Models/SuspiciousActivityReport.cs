namespace MemoEngine.Models;

public class SuspiciousActivityReport
{
    public int Id { get; set; } // 보고서 ID (자동증가)
    public bool ReportCorrectionIndicator { get; set; } // 보고서 수정 여부
    public bool Subject_Multiple { get; set; } // 여러 명의 대상 여부
    public string? FirstName { get; set; } // 이름
    public char? MiddleInitial { get; set; } // 중간 이니셜
    public string? LastName { get; set; } // 성
    public string? AlsoKnownAs { get; set; } // 다른 이름 (AKA)
    public string? DoingBusinessAs { get; set; } // 사업명 (DBA)
    public string? Occupation { get; set; } // 직업/사업 종류
    public string? Address { get; set; } // 주소
    public string? City { get; set; } // 도시
    public string? State { get; set; } // 주/도
    public string? ZIPCode { get; set; } // 우편번호
    public string? Country { get; set; } // 국가
    public DateTime? DateOfBirth { get; set; } // 생년월일
    public string? GovtIssuedID_Type { get; set; } // 정부 발행 신분증 종류
    public string? GovtIssuedID_Number { get; set; } // 정부 발행 신분증 번호
    public string? GovtIssuedID_IssuingState { get; set; } // 신분증 발행 주/도
    public string? SSN { get; set; } // 사회보장번호 (SSN)
    public string? ITIN { get; set; } // 개인 납세자 식별 번호 (ITIN)
    public string? EIN { get; set; } // 고용주 식별 번호 (EIN)
    public string? AccountNumber { get; set; } // 계좌 번호
    public string? PhoneNumberHome { get; set; } // 집 전화번호
    public string? PhoneNumberWork { get; set; } // 직장 전화번호
    public string? EmailAddress { get; set; } // 이메일 주소
    public string? VehicleLicenseNumber { get; set; } // 차량 번호판 번호
    public string? VehicleLicenseState { get; set; } // 차량 번호판 발행 주/도
    public string? CasinoAffiliation { get; set; } // 카지노 연관 (고객, 대리인 등)
    public string? BusinessRelationshipStatus { get; set; } // 사업 관계 상태
    public string? SuspiciousActivityType { get; set; } // 의심스러운 활동 유형
    public DateTime? SuspiciousActivityStartDate { get; set; } // 의심스러운 활동 시작일
    public DateTime? SuspiciousActivityEndDate { get; set; } // 의심스러운 활동 종료일
    public decimal? SuspiciousActivityAmount { get; set; } // 의심스러운 활동 금액
    public string? LawEnforcementContacted { get; set; } // 연락한 법집행 기관
    public string? ContactPersonName { get; set; } // 연락 담당자 이름
    public string? ContactPersonPhone { get; set; } // 연락 담당자 전화번호
    public DateTime? ContactDate { get; set; } // 연락 날짜
    public string? ReportingCasinoTradeName { get; set; } // 보고하는 카지노 상호명
    public string? ReportingCasinoLegalName { get; set; } // 보고하는 카지노 법적 명칭
    public string? CasinoAddress { get; set; } // 카지노 주소
    public string? CasinoCity { get; set; } // 카지노 도시
    public string? CasinoState { get; set; } // 카지노 주/도
    public string? CasinoZIPCode { get; set; } // 카지노 우편번호
    public string? GamingInstitutionType { get; set; } // 게임 기관 유형
    public string? CasinoEIN { get; set; } // 카지노 고용주 식별 번호 (EIN)
    public string? ContactLastName { get; set; } // 담당자 성
    public string? ContactFirstName { get; set; } // 담당자 이름
    public char? ContactMiddleInitial { get; set; } // 담당자 중간 이니셜
    public string? ContactTitle { get; set; } // 담당자 직함
    public string? ContactWorkPhone { get; set; } // 담당자 직장 전화번호
    public DateTime? ReportPreparedDate { get; set; } // 보고서 작성일
    public string? NarrativeDescription { get; set; } // 설명 내용
}
