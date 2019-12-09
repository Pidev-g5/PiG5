package model;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the Users database table.
 * 
 */
@Entity
@Table(name="Users")
@NamedQuery(name="User.findAll", query="SELECT u FROM User u")
public class User implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="Id")
	private int id;

	@Column(name="AccessFailedCount")
	private int accessFailedCount;

	@Column(name="Address")
	private String address;

	@Column(name="BirthDate")
	private String birthDate;

	@Column(name="Candidat_Bio")
	private String candidat_Bio;

	@Column(name="Candidat_facebookLink")
	private String candidat_facebookLink;

	@Column(name="Candidat_linkedInLink")
	private String candidat_linkedInLink;

	@Column(name="Candidat_TwitterLink")
	private String candidat_TwitterLink;

	@Column(name="Candidat_WebSite")
	private String candidat_WebSite;

	@Column(name="Countries")
	private int countries;

	@Column(name="Discriminator")
	private String discriminator;

	@Column(name="Email")
	private String email;

	@Column(name="EmailConfirmed")
	private boolean emailConfirmed;

	private String FName;

	private String LName;

	@Column(name="LockoutEnabled")
	private boolean lockoutEnabled;

	@Column(name="LockoutEndDateUtc")
	private String lockoutEndDateUtc;

	@Column(name="Password")
	private String password;

	@Column(name="PasswordHash")
	private String passwordHash;

	@Column(name="PhoneNumber")
	private String phoneNumber;

	@Column(name="PhoneNumberConfirmed")
	private boolean phoneNumberConfirmed;

	@Column(name="Photo")
	private String photo;

	@Column(name="Role")
	private String role;

	@Column(name="SecurityStamp")
	private String securityStamp;

	@Column(name="StatusCandidate")
	private int statusCandidate;

	@Column(name="TwoFactorEnabled")
	private boolean twoFactorEnabled;

	@Column(name="UserName")
	private String userName;

	//bi-directional many-to-one association to TestMark
	@OneToMany(mappedBy="user")
	private List<TestMark> testMarks;

	//bi-directional many-to-one association to Test
	@ManyToOne
	@JoinColumn(name="TestId")
	private Test test;

	public User() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getAccessFailedCount() {
		return this.accessFailedCount;
	}

	public void setAccessFailedCount(int accessFailedCount) {
		this.accessFailedCount = accessFailedCount;
	}

	public String getAddress() {
		return this.address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getBirthDate() {
		return this.birthDate;
	}

	public void setBirthDate(String birthDate) {
		this.birthDate = birthDate;
	}

	public String getCandidat_Bio() {
		return this.candidat_Bio;
	}

	public void setCandidat_Bio(String candidat_Bio) {
		this.candidat_Bio = candidat_Bio;
	}

	public String getCandidat_facebookLink() {
		return this.candidat_facebookLink;
	}

	public void setCandidat_facebookLink(String candidat_facebookLink) {
		this.candidat_facebookLink = candidat_facebookLink;
	}

	public String getCandidat_linkedInLink() {
		return this.candidat_linkedInLink;
	}

	public void setCandidat_linkedInLink(String candidat_linkedInLink) {
		this.candidat_linkedInLink = candidat_linkedInLink;
	}

	public String getCandidat_TwitterLink() {
		return this.candidat_TwitterLink;
	}

	public void setCandidat_TwitterLink(String candidat_TwitterLink) {
		this.candidat_TwitterLink = candidat_TwitterLink;
	}

	public String getCandidat_WebSite() {
		return this.candidat_WebSite;
	}

	public void setCandidat_WebSite(String candidat_WebSite) {
		this.candidat_WebSite = candidat_WebSite;
	}

	public int getCountries() {
		return this.countries;
	}

	public void setCountries(int countries) {
		this.countries = countries;
	}

	public String getDiscriminator() {
		return this.discriminator;
	}

	public void setDiscriminator(String discriminator) {
		this.discriminator = discriminator;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public boolean getEmailConfirmed() {
		return this.emailConfirmed;
	}

	public void setEmailConfirmed(boolean emailConfirmed) {
		this.emailConfirmed = emailConfirmed;
	}

	public String getFName() {
		return this.FName;
	}

	public void setFName(String FName) {
		this.FName = FName;
	}

	public String getLName() {
		return this.LName;
	}

	public void setLName(String LName) {
		this.LName = LName;
	}

	public boolean getLockoutEnabled() {
		return this.lockoutEnabled;
	}

	public void setLockoutEnabled(boolean lockoutEnabled) {
		this.lockoutEnabled = lockoutEnabled;
	}

	public String getLockoutEndDateUtc() {
		return this.lockoutEndDateUtc;
	}

	public void setLockoutEndDateUtc(String lockoutEndDateUtc) {
		this.lockoutEndDateUtc = lockoutEndDateUtc;
	}

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getPasswordHash() {
		return this.passwordHash;
	}

	public void setPasswordHash(String passwordHash) {
		this.passwordHash = passwordHash;
	}

	public String getPhoneNumber() {
		return this.phoneNumber;
	}

	public void setPhoneNumber(String phoneNumber) {
		this.phoneNumber = phoneNumber;
	}

	public boolean getPhoneNumberConfirmed() {
		return this.phoneNumberConfirmed;
	}

	public void setPhoneNumberConfirmed(boolean phoneNumberConfirmed) {
		this.phoneNumberConfirmed = phoneNumberConfirmed;
	}

	public String getPhoto() {
		return this.photo;
	}

	public void setPhoto(String photo) {
		this.photo = photo;
	}

	public String getRole() {
		return this.role;
	}

	public void setRole(String role) {
		this.role = role;
	}

	public String getSecurityStamp() {
		return this.securityStamp;
	}

	public void setSecurityStamp(String securityStamp) {
		this.securityStamp = securityStamp;
	}

	public int getStatusCandidate() {
		return this.statusCandidate;
	}

	public void setStatusCandidate(int statusCandidate) {
		this.statusCandidate = statusCandidate;
	}

	public boolean getTwoFactorEnabled() {
		return this.twoFactorEnabled;
	}

	public void setTwoFactorEnabled(boolean twoFactorEnabled) {
		this.twoFactorEnabled = twoFactorEnabled;
	}

	public String getUserName() {
		return this.userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public List<TestMark> getTestMarks() {
		return this.testMarks;
	}

	public void setTestMarks(List<TestMark> testMarks) {
		this.testMarks = testMarks;
	}

	public TestMark addTestMark(TestMark testMark) {
		getTestMarks().add(testMark);
		testMark.setUser(this);

		return testMark;
	}

	public TestMark removeTestMark(TestMark testMark) {
		getTestMarks().remove(testMark);
		testMark.setUser(null);

		return testMark;
	}

	public Test getTest() {
		return this.test;
	}

	public void setTest(Test test) {
		this.test = test;
	}

}