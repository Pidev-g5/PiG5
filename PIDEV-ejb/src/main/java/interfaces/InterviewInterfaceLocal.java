package interfaces;

import java.util.List;

import javax.ejb.Local;

import model.Interview;
import model.Reserved;



@Local
public interface InterviewInterfaceLocal {
	public int addInterview(Interview o);
	public List<Interview> getAllInterview();
	public void updateInterview(Interview p);
	public void deleteInterviewById(int InterviewId);
	public void changeStatusById(int InterviewId);
	public void changeStatusAById(int InterviewId);
	public void changeStatusCById(int InterviewId);
	public void changeStatusFById(int InterviewId);
	public void updateInterviewRes(int InterviewId);
	public void updateInterviewResMinus(int InterviewId);
	 
}
