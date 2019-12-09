package model;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the Test database table.
 * 
 */
@Entity
@NamedQuery(name="Test.findAll", query="SELECT t FROM Test t")
public class Test implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="TestId")
	private int testId;

	@Column(name="DateTest")
	private String dateTest;

	private int score;

	@Column(name="StatusTest")
	private String statusTest;

	@Column(name="TestName")
	private String testName;

	@Column(name="TypeTest")
	private int typeTest;

	//bi-directional many-to-one association to Question
	@OneToMany(mappedBy="test")
	private List<Question> questions;

	//bi-directional many-to-one association to TestMark
	@OneToMany(mappedBy="test")
	private List<TestMark> testMarks;

	//bi-directional many-to-one association to User
	@OneToMany(mappedBy="test")
	private List<User> users;

	public Test() {
	}

	public int getTestId() {
		return this.testId;
	}

	public void setTestId(int testId) {
		this.testId = testId;
	}

	public String getDateTest() {
		return this.dateTest;
	}

	public void setDateTest(String dateTest) {
		this.dateTest = dateTest;
	}

	public int getScore() {
		return this.score;
	}

	public void setScore(int score) {
		this.score = score;
	}

	public String getStatusTest() {
		return this.statusTest;
	}

	public void setStatusTest(String statusTest) {
		this.statusTest = statusTest;
	}

	public String getTestName() {
		return this.testName;
	}

	public void setTestName(String testName) {
		this.testName = testName;
	}

	public int getTypeTest() {
		return this.typeTest;
	}

	public void setTypeTest(int typeTest) {
		this.typeTest = typeTest;
	}

	public List<Question> getQuestions() {
		return this.questions;
	}

	public void setQuestions(List<Question> questions) {
		this.questions = questions;
	}

	public Question addQuestion(Question question) {
		getQuestions().add(question);
		question.setTest(this);

		return question;
	}

	public Question removeQuestion(Question question) {
		getQuestions().remove(question);
		question.setTest(null);

		return question;
	}

	public List<TestMark> getTestMarks() {
		return this.testMarks;
	}

	public void setTestMarks(List<TestMark> testMarks) {
		this.testMarks = testMarks;
	}

	public TestMark addTestMark(TestMark testMark) {
		getTestMarks().add(testMark);
		testMark.setTest(this);

		return testMark;
	}

	public TestMark removeTestMark(TestMark testMark) {
		getTestMarks().remove(testMark);
		testMark.setTest(null);

		return testMark;
	}

	public List<User> getUsers() {
		return this.users;
	}

	public void setUsers(List<User> users) {
		this.users = users;
	}

	public User addUser(User user) {
		getUsers().add(user);
		user.setTest(this);

		return user;
	}

	public User removeUser(User user) {
		getUsers().remove(user);
		user.setTest(null);

		return user;
	}

}