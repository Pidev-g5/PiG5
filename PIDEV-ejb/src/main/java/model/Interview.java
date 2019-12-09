package model;

import java.io.Serializable;
import javax.persistence.*;

import java.util.Date;
import java.util.List;


/**
 * The persistent class for the Interview database table.
 * 
 */
@Entity
@NamedQuery(name="Interview.findAll", query="SELECT i FROM Interview i")
public class Interview implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="InterviewId")
	private int interviewId;

	@Column(name="Capacity")
	private int capacity;

	@Column(name="Date")
	private Date date;
	
	@Column(name="Status")
	private String status;

	//bi-directional many-to-one association to Person
	@ManyToOne
	@JoinColumn(name="PersonId")
	private Person person;

	//bi-directional many-to-one association to Person
	//@OneToMany(mappedBy="interview")
	//private List<Person> persons;

	public Interview() {
	}
	

	public Interview(int interviewId, String status) {
		super();
		this.interviewId = interviewId;
		this.status = status;
	}


	public String getStatus() {
		return status;
	}


	public void setStatus(String status) {
		this.status = status;
	}


	public Interview(int interviewId, int capacity) {
		super();
		this.interviewId = interviewId;
		this.capacity = capacity;
	}


	public Interview(int interviewId, int capacity, Date date) {
		super();
		this.interviewId = interviewId;
		this.capacity = capacity;
		this.date = date;
	}


	public Interview(Date date) {
		super();
		this.date = date;
	}


	public Interview(int interviewId, Date date) {
		super();
		this.interviewId = interviewId;
		this.date = date;
	}


	public Interview(int interviewId, int capacity, Date date, Person person) {
		super();
		this.interviewId = interviewId;
		this.capacity = capacity;
		this.date = date;
		this.person = person;
	}


	public int getInterviewId() {
		return this.interviewId;
	}

	public void setInterviewId(int interviewId) {
		this.interviewId = interviewId;
	}

	public int getCapacity() {
		return this.capacity;
	}

	public void setCapacity(int capacity) {
		this.capacity = capacity;
	}

	public Date getDate() {
		return this.date;
	}

	public void setDate(Date date) {
		this.date = date;
	}

	public Person getPerson() {
		return this.person;
	}

	public void setPerson(Person person) {
		this.person = person;
	}

	//public List<Person> getPersons() {
	//	return this.persons;
	//}

	//public void setPersons(List<Person> persons) {
	//	this.persons = persons;
	//}

	/*public Person addPerson(Person person) {
		getPersons().add(person);
		person.setInterview(this);

		return person;
	}

	public Person removePerson(Person person) {
		getPersons().remove(person);
		person.setInterview(null);

		return person;
	}*/

}