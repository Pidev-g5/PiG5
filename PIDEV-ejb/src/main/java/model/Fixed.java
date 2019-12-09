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
@NamedQuery(name="Fixed.findAll", query="SELECT i FROM Fixed i")
public class Fixed implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="FixedId")
	private int fixedId;

	@Column(name="Capacity")
	private int capacity;

	@Column(name="Date")
	private Date date;

	public Fixed(Date date, Reserved reserved) {
		super();
		this.date = date;
		this.reserved = reserved;
	}

	//bi-directional many-to-one association to Interview
	@ManyToOne
	@JoinColumn(name="ReservedId")
	private Reserved reserved;

	
	public Fixed() {
	}
	

	


	public Fixed(int fixedId, int capacity, Date date) {
		super();
		this.fixedId = fixedId;
		this.capacity = capacity;
		this.date = date;
	}


	public Fixed(Date date) {
		super();
		this.date = date;
	}


	public Fixed(int fixedId, Date date) {
		super();
		this.fixedId = fixedId;
		this.date = date;
	}


	public Fixed(int fixedId, int capacity, Date date, Reserved reserved) {
		super();
		this.fixedId = fixedId;
		this.capacity = capacity;
		this.date = date;
		this.reserved = reserved;
	}


	public int getFixedId() {
		return this.fixedId;
	}

	public void setFixedId(int fixedId) {
		this.fixedId = fixedId;
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

	public Reserved getReserved() {
		return this.reserved;
	}

	public void setReserved(Reserved reserved) {
		this.reserved = reserved;
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