package interfaces;

import java.util.List;

import javax.ejb.Remote;

import model.Fixed;
import model.Interview;
import model.Reserved;

@Remote
public interface FixedInterfaceRemote {
	public int addFixed(Fixed r);
	public Reserved getReservedById(int reservedId);
	public void deleteFixedById(int FixedId);
	public List<Fixed> getAllFixed();
	
}
