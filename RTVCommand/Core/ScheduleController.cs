using RTVCommand.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
using System.Windows.Forms;

namespace RTVCommand.Core
{
    public class ScheduleController
    {
        //Container for currently active schedules
        public List<Schedule> ActiveSchedules = new List<Schedule>();

        //Internal task-scheduler components
        private const string _tsFolder = "RTVCommand";

        //Constructor
        public ScheduleController()
        {
            ScanTaskScheduler();
        }

        //In order to build the list of ActiveSchedules, we need to poll the Windows Task Scheduler.
        private void ScanTaskScheduler()
        {
            using (TaskService ts = new TaskService())
            {
                TaskFolder taskFolder = ts.GetFolder(_tsFolder);
                //If there's no RTVCommand folder, create one
                if(taskFolder == null)
                {
                    ts.RootFolder.CreateFolder(_tsFolder, TaskSecurity.DefaultTaskSecurity);
                }
                //Otherwise, poll all tasks in this folder and add them to the container
                else
                {
                    foreach(Microsoft.Win32.TaskScheduler.Task task in taskFolder.Tasks)
                    {
                        Schedule schedule = new Schedule()
                        {
                            Name = task.Name
                        };
                        ActiveSchedules.Add(schedule);
                    }
                }
            }
        }

        public void CreateScheduleColumns(DataGridView dataGridView)
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewColumn dc1 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "Schedule Name",
                ValueType = typeof(string)
            };

            DataGridViewColumn dc2 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "Start Time",
                ValueType = typeof(int)
            };

            DataGridViewColumn dc3 = new DataGridViewColumn()
            {
                CellTemplate = cell,
                Name = "Target Playlist",
                ValueType = typeof(string)
            };

            dataGridView.Columns.Add(dc1);
            dataGridView.Columns.Add(dc2);
            dataGridView.Columns.Add(dc3);
        }

        /// <summary>
        /// Creates a Schedule object from the supplied Playlist, then inserts it into the Windows Task Scheduler.
        /// </summary>
        /// <param name="playlist"></param>
        public void CreateNewSchedule(Playlist playlist)
        {

        }
    }
}
