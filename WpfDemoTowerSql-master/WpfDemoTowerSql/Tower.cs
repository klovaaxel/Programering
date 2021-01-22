using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemoTowerSql
{
    /// <summary>
    /// A tower with a name and a height in meter.
    /// </summary>
    public class Tower
    {
        // primary key in the database
        private int id;
        private String name;
        private int height;

        /// <summary>
        /// Create a tower with the specified id.
        /// </summary>
        /// <param name="id"></param>
        public Tower(int id)
        {
            this.id = id;
            name = "";
            height = 0;
        }

        /// <summary>
        /// Read the id of this tower.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Get och set the name of the tower.
        /// </summary>
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Get or set the height of the tower.
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        /// <summary>
        /// Returns information about this tower as a string.
        /// </summary>
        /// <returns>Returns name and height as a string.</returns>
        public override string ToString()
        {
            return Name + ", " + Height + "meter";
        }
    }
}
