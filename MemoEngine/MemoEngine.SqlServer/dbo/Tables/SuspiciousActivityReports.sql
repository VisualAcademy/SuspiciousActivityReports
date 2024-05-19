CREATE TABLE SuspiciousActivityReports (
    Id INT IDENTITY(1,1) PRIMARY KEY, -- 보고서 ID (자동증가)
    ReportCorrectionIndicator BIT, -- 보고서 수정 여부
    Subject_Multiple BIT, -- 여러 명의 대상 여부
    FirstName NVARCHAR(100), -- 이름
    MiddleInitial NCHAR(1), -- 중간 이니셜
    LastName NVARCHAR(100), -- 성
    AlsoKnownAs NVARCHAR(200), -- 다른 이름 (AKA)
    DoingBusinessAs NVARCHAR(200), -- 사업명 (DBA)
    Occupation NVARCHAR(150), -- 직업/사업 종류
    Address NVARCHAR(255), -- 주소
    City NVARCHAR(100), -- 도시
    State NVARCHAR(100), -- 주/도
    ZIPCode NVARCHAR(20), -- 우편번호
    Country NVARCHAR(100), -- 국가
    DateOfBirth DATE, -- 생년월일
    GovtIssuedID_Type NVARCHAR(100), -- 정부 발행 신분증 종류
    GovtIssuedID_Number NVARCHAR(100), -- 정부 발행 신분증 번호
    GovtIssuedID_IssuingState NVARCHAR(100), -- 신분증 발행 주/도
    SSN NVARCHAR(15), -- 사회보장번호 (SSN)
    ITIN NVARCHAR(15), -- 개인 납세자 식별 번호 (ITIN)
    EIN NVARCHAR(15), -- 고용주 식별 번호 (EIN)
    AccountNumber NVARCHAR(100), -- 계좌 번호
    PhoneNumberHome NVARCHAR(20), -- 집 전화번호
    PhoneNumberWork NVARCHAR(20), -- 직장 전화번호
    EmailAddress NVARCHAR(150), -- 이메일 주소
    VehicleLicenseNumber NVARCHAR(50), -- 차량 번호판 번호
    VehicleLicenseState NVARCHAR(50), -- 차량 번호판 발행 주/도
    CasinoAffiliation NVARCHAR(100), -- 카지노 연관 (고객, 대리인 등)
    BusinessRelationshipStatus NVARCHAR(100), -- 사업 관계 상태
    SuspiciousActivityType NVARCHAR(255), -- 의심스러운 활동 유형
    SuspiciousActivityStartDate DATE, -- 의심스러운 활동 시작일
    SuspiciousActivityEndDate DATE, -- 의심스러운 활동 종료일
    SuspiciousActivityAmount MONEY, -- 의심스러운 활동 금액
    LawEnforcementContacted NVARCHAR(150), -- 연락한 법집행 기관
    ContactPersonName NVARCHAR(150), -- 연락 담당자 이름
    ContactPersonPhone NVARCHAR(20), -- 연락 담당자 전화번호
    ContactDate DATE, -- 연락 날짜
    ReportingCasinoTradeName NVARCHAR(150), -- 보고하는 카지노 상호명
    ReportingCasinoLegalName NVARCHAR(150), -- 보고하는 카지노 법적 명칭
    CasinoAddress NVARCHAR(255), -- 카지노 주소
    CasinoCity NVARCHAR(100), -- 카지노 도시
    CasinoState NVARCHAR(100), -- 카지노 주/도
    CasinoZIPCode NVARCHAR(20), -- 카지노 우편번호
    GamingInstitutionType NVARCHAR(100), -- 게임 기관 유형
    CasinoEIN NVARCHAR(15), -- 카지노 고용주 식별 번호 (EIN)
    ContactLastName NVARCHAR(100), -- 담당자 성
    ContactFirstName NVARCHAR(100), -- 담당자 이름
    ContactMiddleInitial NCHAR(1), -- 담당자 중간 이니셜
    ContactTitle NVARCHAR(100), -- 담당자 직함
    ContactWorkPhone NVARCHAR(20), -- 담당자 직장 전화번호
    ReportPreparedDate DATE, -- 보고서 작성일
    NarrativeDescription NVARCHAR(MAX) -- 설명 내용
);
