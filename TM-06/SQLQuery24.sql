select jobs.job_desc,count(emp_id) as total_no from employee join jobs on employee.job_id=jobs.job_id group by jobs.job_desc;
