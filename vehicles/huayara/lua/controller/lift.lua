-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}
local logTag = "lift"
M.type = "auxilliary"
M.relevantDevice = nil
M.defaultOrder = 1000


local function toggleLift()
  controller.getControllerSafe("airbags").toggleBeamMinMax({"rightAxle", "leftAxle"})
end


local function updateGFX(dt)

end

local function reset()

end


local function init(jbeamData)

end


local function initSecondStage()

end




M.init = init
M.initSecondStage = initSecondStage
M.reset = reset
M.updateGFX = updateGFX

M.toggleLift = toggleLift

return M
