package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the Jobs database table.
 * 
 */
@Entity
@Table(name="Jobs")
@NamedQuery(name="Job.findAll", query="SELECT j FROM Job j")
public class Job implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="IdJob")
	private int idJob;

	@Column(name="CompanyId")
	private int companyId;

	@Column(name="Deadline")
	private String deadline;

	@Column(name="Description")
	private String description;

	@Column(name="Experience")
	private int experience;

	@Column(name="Gender")
	private int gender;

	@Column(name="Industry")
	private String industry;

	@Column(name="JobType")
	private int jobType;

	@Column(name="PostedDate")
	private String postedDate;

	@Column(name="Qualification")
	private int qualification;

	@Column(name="Salary")
	private float salary;

	@Column(name="Title")
	private String title;

	public Job() {
	}

	public int getIdJob() {
		return this.idJob;
	}

	public void setIdJob(int idJob) {
		this.idJob = idJob;
	}

	public int getCompanyId() {
		return this.companyId;
	}

	public void setCompanyId(int companyId) {
		this.companyId = companyId;
	}

	public String getDeadline() {
		return this.deadline;
	}

	public void setDeadline(String deadline) {
		this.deadline = deadline;
	}

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public int getExperience() {
		return this.experience;
	}

	public void setExperience(int experience) {
		this.experience = experience;
	}

	public int getGender() {
		return this.gender;
	}

	public void setGender(int gender) {
		this.gender = gender;
	}

	public String getIndustry() {
		return this.industry;
	}

	public void setIndustry(String industry) {
		this.industry = industry;
	}

	public int getJobType() {
		return this.jobType;
	}

	public void setJobType(int jobType) {
		this.jobType = jobType;
	}

	public String getPostedDate() {
		return this.postedDate;
	}

	public void setPostedDate(String postedDate) {
		this.postedDate = postedDate;
	}

	public int getQualification() {
		return this.qualification;
	}

	public void setQualification(int qualification) {
		this.qualification = qualification;
	}

	public float getSalary() {
		return this.salary;
	}

	public void setSalary(float salary) {
		this.salary = salary;
	}

	public String getTitle() {
		return this.title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

}