package ManagedBean;


import java.io.Serializable;

import javax.ejb.EJB;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.context.FacesContext;

import model.Person;
import services.PersonService;


@ManagedBean 
@SessionScoped
public class PersonBean implements Serializable{

	private static final long serialVersionUID = 1L;
	private String email; 
	private String password; 
	private Person person; 
	private Boolean loggedIn;
	
	@EJB
	PersonService Pservice;
	
	public String doLogin() {
		String navigateTo= "null";
		person= Pservice.getPersonByEmailAndPassword(email, password);
		if(person!= null&& person.getPersonType().equals("RH")) {
		navigateTo=  "/AdminHome?faces-redirect=true";
		loggedIn= true; 
		}
		else if(person!= null&& person.getPersonType().equals("Visiteur")) {
			navigateTo= "/UserHome?faces-redirect=true";
			loggedIn= true; 
			}
		else{
		FacesContext.getCurrentInstance().addMessage("form:btn", new FacesMessage("Bad Credentials"));}
		return navigateTo;
		}
	
	public String doLogout() {
		FacesContext.getCurrentInstance().getExternalContext().invalidateSession();
		return"/Login?faces-redirect=true"; }
	
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public Person getPerson() {
		return person;
	}
	public void setPerson(Person person) {
		this.person = person;
	}
	public Boolean getLoggedIn() {
		return loggedIn;
	}
	public void setLoggedIn(Boolean loggedIn) {
		this.loggedIn = loggedIn;
	}
	
	
}
