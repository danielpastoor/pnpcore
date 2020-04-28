﻿using System;

namespace PnP.Core.Model.Teams
{
    /// <summary>
    /// Defines the tab in a Team channel
    /// </summary>
    public interface ITeamChannelTab : IDataModel<ITeamChannelTab>, IDataModelDelete, IDataModelUpdate
    {
        /// <summary>
        /// Identifier that uniquely identifies a specific instance of a channel tab. Read only.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the tab.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Deep link url of the tab instance. Read only.
        /// </summary>
        public Uri WebUrl { get; set; }

        /// <summary>
        /// Container for custom settings applied to a tab. The tab is considered configured only once this property is set.
        /// </summary>
        public ITeamChannelTabConfiguration Configuration { get; set; }

        /// <summary>
        /// The application that is linked to the tab. This cannot be changed after tab creation.
        /// </summary>
        public ITeamApp TeamsApp { get; set; }

    }
}
