package interfaces;

import javax.ejb.Local;

import model.Person;
@Local
public interface PersonServiceLocal {
	public Person getPersonByEmailAndPassword(String email, String password);
	public Person getPersonById(int personId); 

}
