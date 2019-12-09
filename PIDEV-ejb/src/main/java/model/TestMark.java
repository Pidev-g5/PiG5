package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the TestMark database table.
 * 
 */
@Entity
@NamedQuery(name="TestMark.findAll", query="SELECT t FROM TestMark t")
public class TestMark implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="TestMarkId")
	private int testMarkId;

	private int mark;

	//bi-directional many-to-one association to Test
	@ManyToOne
	@JoinColumn(name="testId")
	private Test test;

	//bi-directional many-to-one association to User
	@ManyToOne
	@JoinColumn(name="CandidatId")
	private User user;

	public TestMark() {
	}

	public int getTestMarkId() {
		return this.testMarkId;
	}

	public void setTestMarkId(int testMarkId) {
		this.testMarkId = testMarkId;
	}

	public int getMark() {
		return this.mark;
	}

	public void setMark(int mark) {
		this.mark = mark;
	}

	public Test getTest() {
		return this.test;
	}

	public void setTest(Test test) {
		this.test = test;
	}

	public User getUser() {
		return this.user;
	}

	public void setUser(User user) {
		this.user = user;
	}

}