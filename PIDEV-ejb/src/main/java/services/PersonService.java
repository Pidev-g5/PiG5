package services;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

import interfaces.PersonServiceLocal;
import interfaces.PersonServiceRemote;
import model.Person;

@Stateless
@LocalBean
public class PersonService implements PersonServiceRemote,PersonServiceLocal{
	@PersistenceContext(unitName="primary")
	EntityManager em;
	
	@Override
	public Person getPersonByEmailAndPassword(String email, String password) {
		TypedQuery<Person> query = 
				em.createQuery("select e from Person e WHERE e.email=:email and e.password=:password ", Person.class); 
				query.setParameter("email", email); 
				query.setParameter("password", password); 
				Person person = null; 
				try {
					person = query.getSingleResult(); 
				}
				catch (Exception e) {
					System.out.println("Erreur : " + e);
				}
				return person;
	}

	@Override
	public Person getPersonById(int personId) {
		TypedQuery<Person> query = 
				em.createQuery("select e from Person e WHERE e.personId=:personId", Person.class); 
				query.setParameter("personId",personId); 
			
				Person person = null; 
				try {
					person = query.getSingleResult(); 
				}
				catch (Exception e) {
					System.out.println("Erreur : " + e);
				}
				return person;
	}
	
}
