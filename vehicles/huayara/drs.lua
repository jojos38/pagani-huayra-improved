local M = {}

local lightsPDState = 0
--local ToggledPD = false
--local ToggledAlley = false
--local PDlights = 0
local blinkPDTimerThreshold = 1
local blinkPDTimerThresholdHalf = 0
local blinkPDTimer = 0
local blinkPDPulseLeft = 0
local blinkPDPulseRight = 0
local DRS = 0

local function onInit()
    electrics.values['DRS_on'] = 0
    electrics.values['DRS_manual'] = 0
    electrics.values['DRS_ready_pulse'] = 0
    electrics.values['DRS_off'] = 0
    electrics.values.DRS = 0
    electrics.values.DRS_manual = 0
end

local function onReset()
    onInit()
end



local function updateGFX(dt)
	if electrics.values.DRS < 1 then
		if electrics.values['brake'] == 0 and electrics.values['airspeed'] > 50 and electrics.values['steering'] < 15 and electrics.values['steering'] > -15  then
		electrics.values['DRS_on'] = 1 else electrics.values['DRS_on'] = 0
		end
	else 
	if electrics.values.DRS_manual > 0 then 
	electrics.values['DRS_on'] = 1 else electrics.values['DRS_on'] = 0
	gui.message("DRS manual")
	end
	end 
	
end

-- public interface
M.onInit      = onInit
M.onReset     = reset
M.updateGFX = updateGFX

return M