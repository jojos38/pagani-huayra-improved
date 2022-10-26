-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}
M.type = "auxilliary"
M.relevantDevice = nil

local speedThresholdNormalPosition = 20
local speedThresholdClosedPosition = 20
local speedThresholdBrakingPosition = 20
local brakeThresholdBrakingPosition = 0.5

local spoilerRClosed = 0
local spoilerRNormal = 0.51
local spoilerRTurning = 0.26
local spoilerRBraking = 1

local function init()
    electrics.values.spoilerR = 0
end

local function updateGFX(dt)
    local spoilerR = electrics.values.spoilerR
    local speed = electrics.values.wheelspeed

    if electrics.values.brake > brakeThresholdBrakingPosition then --check for brake input
        spoilerR = speed >= speedThresholdBrakingPosition and spoilerRBraking or spoilerRClosed
    elseif speed >= speedThresholdNormalPosition then	--we are not braking, check for normal spoiler mode speed
		if sensors.gx2 >= 5 or sensors.gx2 <= -5 then
			if 0.51 - (electrics.values['steering']/120 * 0.26) >= 0 and 0.51 - (electrics.values['steering']/120 * 0.26) <= 1 then  
				spoilerR = 0.51 - (electrics.values['steering']/120 * 0.26)
			end
		else
			spoilerR = spoilerRNormal --(we are above the normal spoiler position speed, so set the spoiler to normal)
		end
    else --we are not braking AND below the normal position speed
		if ((sensors.gx2 >= 5 or sensors.gx2 <= -5) or speed < speedThresholdNormalPosition) and spoilerR ~= spoilerRClosed then
			spoilerR = spoilerRClosed
		end
        
    end

    electrics.values.spoilerR = spoilerR
end

M.init = init
M.updateGFX = updateGFX

return M