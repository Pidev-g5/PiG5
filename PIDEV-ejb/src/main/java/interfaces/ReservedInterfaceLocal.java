package interfaces;



import java.util.Date;
import java.util.List;

import javax.ejb.Local;

import model.Interview;
import model.Reserved;

@Local
public interface ReservedInterfaceLocal {
	public int addReserved(Reserved r);
	public Interview getInterviewById(int interviewId);
	public void deleteReservedById(int ReservedId);
	public List<Reserved> getAllReserved();
	public int CapacityInter(int ReservedId);
	public void changeCapacityById(int ReservedId);
	public void updateReserved(Reserved p);
	public Reserved getReservedById(int reservedId);
	public int SearchRes(Date dateR, int interviewId);
	
}
