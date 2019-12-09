package model;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the Person database table.
 * 
 */
@Entity
@NamedQuery(name="Person.findAll", query="SELECT p FROM Person p")
public class Person implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="PersonId")
	private int personId;

	@Column(name="Email")
	private String email;

	private String FName;

	private String LName;

	@Column(name="Password")
	private String password;

	@Column(name="PersonType")
	private String personType;

	//bi-directional many-to-one association to Interview
	@OneToMany(mappedBy="person")
	private List<Interview> interviews;
	
	
	
	
	public Person() {
	}

	
	public int getPersonId() {
		return this.personId;
	}

	public void setPersonId(int personId) {
		this.personId = personId;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
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

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getPersonType() {
		return this.personType;
	}

	public void setPersonType(String personType) {
		this.personType = personType;
	}

	public List<Interview> getInterviews() {
		return this.interviews;
	}

	public void setInterviews(List<Interview> interviews) {
		this.interviews = interviews;
	}

	public Interview addInterview(Interview interview) {
		getInterviews().add(interview);
		interview.setPerson(this);

		return interview;
	}

	public Interview removeInterview(Interview interview) {
		getInterviews().remove(interview);
		interview.setPerson(null);

		return interview;
	}

}