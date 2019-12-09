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
@NamedQuery(name="Reserved.findAll", query="SELECT i FROM Reserved i")
public class Reserved implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="ReservedId")
	private int reservedId;

	@Column(name="Capacity")
	private int capacity;

	@Column(name="Date")
	private Date date;

	public Reserved(Date date, Interview interview) {
		super();
		this.date = date;
		this.interview = interview;
	}

	//bi-directional many-to-one association to Interview
	@ManyToOne
	@JoinColumn(name="InterviewId")
	private Interview interview;

	
	public Reserved() {
	}
	

	


	public Reserved(int reservedId, int capacity, Date date) {
		super();
		this.reservedId = reservedId;
		this.capacity = capacity;
		this.date = date;
	}


	public Reserved(Date date) {
		super();
		this.date = date;
	}


	public Reserved(int reservedId, Date date) {
		super();
		this.reservedId = reservedId;
		this.date = date;
	}


	public Reserved(int reservedId, int capacity, Date date, Interview interview) {
		super();
		this.reservedId = reservedId;
		this.capacity = capacity;
		this.date = date;
		this.interview = interview;
	}


	public int getReservedId() {
		return this.reservedId;
	}

	public void setReservedId(int reservedId) {
		this.reservedId = reservedId;
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

	public Interview getInterview() {
		return this.interview;
	}

	public void setInterview(Interview interview) {
		this.interview = interview;
	}





	public Reserved(int reservedId) {
		super();
		this.reservedId = reservedId;
	}





	public Reserved(int reservedId, int capacity) {
		super();
		this.reservedId = reservedId;
		this.capacity = capacity;
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