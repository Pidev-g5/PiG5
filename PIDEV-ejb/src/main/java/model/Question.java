package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the Question database table.
 * 
 */
@Entity
@NamedQuery(name="Question.findAll", query="SELECT q FROM Question q")
public class Question implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="QstId")
	private int qstId;

	private String qQst;

	@Column(name="Rep1")
	private String rep1;

	@Column(name="Rep2")
	private String rep2;

	@Column(name="Rep3")
	private String rep3;

	@Column(name="Rep4")
	private String rep4;

	@Column(name="RepCorrect")
	private String repCorrect;

	//bi-directional many-to-one association to Test
	@ManyToOne
	@JoinColumn(name="TestId")
	private Test test;

	public Question() {
	}

	public int getQstId() {
		return this.qstId;
	}

	public void setQstId(int qstId) {
		this.qstId = qstId;
	}

	public String getQQst() {
		return this.qQst;
	}

	public void setQQst(String qQst) {
		this.qQst = qQst;
	}

	public String getRep1() {
		return this.rep1;
	}

	public void setRep1(String rep1) {
		this.rep1 = rep1;
	}

	public String getRep2() {
		return this.rep2;
	}

	public void setRep2(String rep2) {
		this.rep2 = rep2;
	}

	public String getRep3() {
		return this.rep3;
	}

	public void setRep3(String rep3) {
		this.rep3 = rep3;
	}

	public String getRep4() {
		return this.rep4;
	}

	public void setRep4(String rep4) {
		this.rep4 = rep4;
	}

	public String getRepCorrect() {
		return this.repCorrect;
	}

	public void setRepCorrect(String repCorrect) {
		this.repCorrect = repCorrect;
	}

	public Test getTest() {
		return this.test;
	}

	public void setTest(Test test) {
		this.test = test;
	}

}