﻿using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using Valour.Client.Channels;
using Valour.Client.Shared.Modals;
using Valour.Client.Shared.Modals.ContextMenus;

/*  Valour - A free and secure chat client
*  Copyright (C) 2021 Vooper Media LLC
*  This program is subject to the GNU Affero General Public license
*  A copy of the license should be included - if not, see <http://www.gnu.org/licenses/>
*/

namespace Valour.Client.Modals
{
    /// <summary>
    /// Assists in controlling the planet creation modal
    /// </summary>
    public class CreatePlanetModal
    {
        public readonly IJSRuntime JS;
        public CreatePlanetModalComponent Component;
        public Func<Task> OpenEvent;

        public CreatePlanetModal(IJSRuntime js)
        {
            JS = js;
        }

        public async Task Open()
        {

            Component.SetVisibility(true);

            if (OpenEvent != null)
            {
                await OpenEvent.Invoke();
            }
        }
    }
}
