package interfaces;

import javax.ejb.Remote;

import model.Person;

@Remote
public interface PersonServiceRemote {
	public Person getPersonByEmailAndPassword(String email, String password); 
	public Person getPersonById(int personId); 
}
