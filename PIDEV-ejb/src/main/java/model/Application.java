package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the Application database table.
 * 
 */
@Entity
@NamedQuery(name="Application.findAll", query="SELECT a FROM Application a")
public class Application implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="AppId")
	private int appId;

	@Column(name="ApplicationStatus")
	private String applicationStatus;

	@Column(name="CandId")
	private int candId;

	@Column(name="Nom")
	private String nom;

	@Column(name="OfferId")
	private int offerId;

	@Column(name="Prenom")
	private String prenom;

	public Application() {
	}

	public int getAppId() {
		return this.appId;
	}

	public void setAppId(int appId) {
		this.appId = appId;
	}

	public String getApplicationStatus() {
		return this.applicationStatus;
	}

	public void setApplicationStatus(String applicationStatus) {
		this.applicationStatus = applicationStatus;
	}

	public int getCandId() {
		return this.candId;
	}

	public void setCandId(int candId) {
		this.candId = candId;
	}

	public String getNom() {
		return this.nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public int getOfferId() {
		return this.offerId;
	}

	public void setOfferId(int offerId) {
		this.offerId = offerId;
	}

	public String getPrenom() {
		return this.prenom;
	}

	public void setPrenom(String prenom) {
		this.prenom = prenom;
	}

}